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
        private int[] trackBarValues = new int[8];
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
            scrollPosition = 0;
            vScrollBar1.Value = 0;
            drawImage(_fileData);
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

                        //int scaledBrightness = (brightness >> shift) & 0xFF;
                        int scaledBrightness = calculateBrightness(pixelValue);

                        Color pixelColor = Color.FromArgb(scaledBrightness, scaledBrightness, scaledBrightness);
                        zoomedImage.SetPixel(xZoom, yZoom, pixelColor);
                    }
                }
                originalImage = zoomedImage;
                graphics.Image = zoomedImage;
            }
        }

        private void TrackBar_Scroll(object sender, EventArgs e)
        {
            System.Windows.Forms.TrackBar trackBar = (System.Windows.Forms.TrackBar)sender;
            int index = int.Parse(trackBar.Name.Replace("trackBar", "")) - 1; // Получаем индекс ползунка
            trackBarValues[index] = trackBar.Value; // Сохраняем значение ползунка
            drawImage(_fileData); // Перерисовываем изображение
        }
        private int calculateBrightness(int brightness)
        {
            // Убедитесь, что brightness находится в допустимом диапазоне
            brightness = Math.Max(0, Math.Min(brightness, 1023));

            // Найдем, в каком отрезке находится brightness
            int segment = 0;
            for (int i = 0; i < trackBarValues.Length - 1; i++)
            {
                if (brightness >= trackBarValues[i] && brightness <= trackBarValues[i + 1])
                {
                    segment = i;
                    break;
                }
            }
            // Получаем значения для интерполяции
            int x0 = trackBarValues[segment];
            int x1 = trackBarValues[segment + 1];
            // Нормализуем значение y в диапазоне от 0 до 255
            int y0 = (segment * 255) / (trackBarValues.Length - 1);
            int y1 = ((segment + 1) * 255) / (trackBarValues.Length - 1);
            // Проверка на случай, если x0 и x1 равны
            if (x1 == x0)
            {
                return y0; // Если x0 и x1 равны, возвращаем y0
            }
            // Линейная интерполяция
            int scaledBrightness = y0 + (y1 - y0) * (brightness - x0) / (x1 - x0);
            return Math.Max(0, Math.Min(scaledBrightness, 255)); // Ограничиваем результат от 0 до 255
        }

    }

}
