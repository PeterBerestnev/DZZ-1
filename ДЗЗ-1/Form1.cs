using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ДЗЗ_1
{
    public partial class Form1 : Form
    {
        private byte[] _fileData;
        private int shift = 0;
        private int topPixel;
        private int width;
        private int height;
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
                    drawImage(_fileData);

                    listView1.Columns.Add("Файл");
                    ListViewItem item = new ListViewItem(openFileDialog1.FileName);
                    listView1.Items.Add(item);

                    // Установите ширину первой колонки на всю ширину ListView
                    listView1.Columns[0].Width = (int)(listView1.Width * 1);
                    vScrollBar1.Maximum = height - graphics.Height;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading file: " + ex.Message);
                }

            }
        }

        private void drawImage(byte[] image)
        {
            Bitmap bitmap = new Bitmap(width, height);

            for (int y = topPixel; y < height && y < topPixel + bitmap.Height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int pixelOffset = 4 + (y * width * 2) + (x * 2);
                    ushort pixelValue = BitConverter.ToUInt16(image, pixelOffset);

                    int brightness = (pixelValue & 0x3FF);

                    int scaledBrightness = (brightness >> shift) & 0xFF;

                    Color pixelColor = Color.FromArgb(scaledBrightness, scaledBrightness, scaledBrightness);
                    bitmap.SetPixel(x, y - topPixel, pixelColor);
                }
            }

            graphics.Image = bitmap;
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
                int y = e.Y + topPixel;

                Bitmap bitmap = (Bitmap)graphics.Image;

                if (x >= 0 && x < bitmap.Width && y >= 0 && y < bitmap.Height + topPixel)
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

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (graphics.Image != null)
            {
                topPixel = e.NewValue * (height-graphics.Height) / vScrollBar1.Maximum;

                drawImage(_fileData);
            }
        }

    }
}
