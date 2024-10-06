using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ДЗЗ_1
{
    public partial class Form1 : Form
    {
        private byte[] _fileData;
        private int shift = 0;
        private int scrollPosition;
        private int zoomVarX = 0;
        private int zoomVarY = 0;
        private int width;
        private int height;
        private int zoomLevel = 1;
        private int minBrightness;
        private int maxBrightness;
        private Bitmap originalImage;
        public Form1()
        {
            InitializeComponent();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _fileData = File.ReadAllBytes(openFileDialog1.FileName);
                    width = BitConverter.ToInt16(_fileData, 0);
                    height = BitConverter.ToInt16(_fileData, 2);

                    listView1.Columns.Add("Файл");
                    ListViewItem item = new ListViewItem(openFileDialog1.FileName);
                    listView1.Items.Add(item);

                    listView1.Columns[0].Width = (int)(listView1.Width * 1);
                    vScrollBar1.Maximum = height - graphics.Height;
                    for (int y = 0; y < height; y++)
                    {
                        for (int x = 0; x < width; x++)
                        {
                            int pixelOffset = 4 + (y * width * 2) + (x * 2);
                            ushort pixelValue = BitConverter.ToUInt16(_fileData, pixelOffset);
                            int currentBrightness = (pixelValue & 0x3FF);

                            if (currentBrightness < minBrightness)
                            {
                                minBrightness = currentBrightness;
                            }

                            if (currentBrightness > maxBrightness)
                            {
                                maxBrightness = currentBrightness;
                            }
                        }
                    }

                    resetParams();
                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading file: " + ex.Message);
                }

            }
        }

        private void resetParams()
        {
            //Reset Params
            shift = 0;
            scrollPosition = 0;
            vScrollBar1.Value = 0;
            zoomLevel = 1;
            label2.Text = $"x{zoomLevel}";
            zoomVarY = 0;
            zoomVarX = 0;
            checkBox1.Checked = false;
            drawImage(_fileData);
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            int radioButtonNumber = int.Parse(radioButton.Name.Replace("radioButton", ""));
            shift = radioButtonNumber - 1;

            drawImage(_fileData);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

            if (graphics.Image != null)
            {
                int x = e.X;
                int y = e.Y + scrollPosition;

                Bitmap bitmap = (Bitmap)graphics.Image;

                if (x >= 0 && x < bitmap.Width && y >= 0 && y < bitmap.Height + scrollPosition)
                {
                    Color pixelColor = bitmap.GetPixel(x, y);

                    int pixelOffset = 4 + (y * width * 2) + (x * 2);
                    ushort pixelValue = BitConverter.ToUInt16(_fileData, pixelOffset);
                    int brightness = (pixelValue & 0x3FF);

                    textBox1.Text = $"{x}";
                    textBox3.Text = $"{y}";
                    textBox4.Text = $" {brightness}";

                }
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (graphics.Image != null)
            {
                int x = e.X + zoomVarX;
                int y = e.Y + scrollPosition + zoomVarY;

                Bitmap bitmap = (Bitmap)graphics.Image;

                if (x >= 0 && x < bitmap.Width && y >= 0 && y < bitmap.Height + scrollPosition)
                {
                    // Увеличить изображение
                    zoomLevel++;

                    // Обновить topPixel и leftPixel в зависимости от центра
                    zoomVarY = y;
                    zoomVarX = x;
                    label2.Text = $"x{zoomLevel}";
                    drawImage(_fileData);
                }
            }
        }

        private void drawImage(byte[] image)
        {
            if (image != null)
            {
                // Apply the current zoom level
                int newWidth = (int)(width * zoomLevel);
                int newHeight = (int)(height * zoomLevel);

                Bitmap zoomedImage = new Bitmap(newWidth, newHeight);

                for (int yZoom = 0; yZoom < graphics.Height; yZoom++)
                {
                    for (int xZoom = 0; xZoom < newWidth; xZoom++)
                    {
                        int nearestX = (xZoom + zoomVarX) / zoomLevel;
                        int nearestY = (yZoom + zoomVarY + scrollPosition) / zoomLevel;

                        // Clamp nearestX and nearestY to the original image bounds
                        nearestX = Math.Max(0, Math.Min(nearestX, width - 1));
                        nearestY = Math.Max(0, Math.Min(nearestY, height - 1));

                        int pixelOffset = 4 + (nearestY * width * 2) + (nearestX * 2);
                        ushort pixelValue = BitConverter.ToUInt16(image, pixelOffset);

                        int brightness = GetBrightness(image, pixelOffset, nearestX, nearestY, xZoom, yZoom);

                        if (checkBox2.Checked)
                        {
                            brightness = NormalizeBrightness(brightness);
                        }

                        int scaledBrightness = (brightness >> shift) & 0xFF;

                        Color pixelColor = Color.FromArgb(scaledBrightness, scaledBrightness, scaledBrightness);
                        zoomedImage.SetPixel(xZoom, yZoom, pixelColor);
                    }
                }
                originalImage = zoomedImage;
                graphics.Image = zoomedImage;
            }
        }

        private int NormalizeBrightness(int brightness)
        {
            return (int)((brightness - minBrightness) / (float)(maxBrightness - minBrightness) * 255);
        }

        private int GetBrightness(byte[] image, int pixelOffset, int nearestX, int nearestY, int xZoom, int yZoom)
        {
            if (checkBox1.Checked)
            {
                return GetBilinearInterpolationBrightness(image, nearestX, nearestY, xZoom, yZoom);
            }
            else
            {
                // Nearest neighbor interpolation
                return (BitConverter.ToUInt16(image, pixelOffset) & 0x3FF);
            }
        }

        private int GetBilinearInterpolationBrightness(byte[] image, int nearestX, int nearestY, int xZoom, int yZoom)
        {
            int x0 = Math.Max(0, Math.Min(nearestX, width - 1));
            int x1 = Math.Max(0, Math.Min(nearestX + 1, width - 1));
            int y0 = Math.Max(0, Math.Min(nearestY, height - 1));
            int y1 = Math.Max(0, Math.Min(nearestY + 1, height - 1));

            int pixelOffset00 = 4 + (y0 * width * 2) + (x0 * 2);
            int pixelOffset10 = 4 + (y0 * width * 2) + (x1 * 2);
            int pixelOffset01 = 4 + (y1 * width * 2) + (x0 * 2);
            int pixelOffset11 = 4 + (y1 * width * 2) + (x1 * 2);

            int brightness00 = (BitConverter.ToUInt16(image, pixelOffset00) & 0x3FF);
            int brightness10 = (BitConverter.ToUInt16(image, pixelOffset10) & 0x3FF);
            int brightness01 = (BitConverter.ToUInt16(image, pixelOffset01) & 0x3FF);
            int brightness11 = (BitConverter.ToUInt16(image, pixelOffset11) & 0x3FF);

            float xFraction = (xZoom + zoomVarX) % zoomLevel / (float)zoomLevel;
            float yFraction = (yZoom + zoomVarY + scrollPosition) % zoomLevel / (float)zoomLevel;

            int brightness = (int)((brightness00 * (1 - xFraction) * (1 - yFraction) +
                                        brightness10 * xFraction * (1 - yFraction) +
                                        brightness01 * (1 - xFraction) * yFraction +
                                        brightness11 * xFraction * yFraction));

            brightness = Math.Max(0, Math.Min(brightness, 255)); // Clamp to 0-255 range

            return brightness;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (graphics.Image != null)
            {
                scrollPosition = e.NewValue * (height - graphics.Height) / vScrollBar1.Maximum;
                drawImage(_fileData);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resetParams();
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            drawImage(_fileData);
        }

        private void checkBox2_CheckStateChanged(object sender, EventArgs e)
        {
            drawImage(_fileData);
        }
    }
}
