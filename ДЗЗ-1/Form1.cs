using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ДЗЗ_1
{
    public partial class Form1 : Form
    {
        private byte[] _fileData;
        private int scrollPosition;
        private int width;
        private int height;
        private int[] trackBarValues = new int[8];
        private Label[] trackBarLabels;

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

                    trackBarLabels = new Label[] {
                         trackBarLabel1,
                         trackBarLabel2,
                         trackBarLabel3,
                         trackBarLabel4,
                         trackBarLabel5,
                         trackBarLabel6,
                         trackBarLabel7,
                         trackBarLabel8
                     };

                    listView1.Columns[0].Width = (int)(listView1.Width * 1);

                    modified.Image = getImage(_fileData);
                    original.Image = getImage(_fileData);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading file: " + ex.Message);
                }

            }
        }

        private Bitmap getImage(byte[] image,bool modificate = false)
        {
            if (image != null)
            {
                // Apply the current zoom level
                int newWidth = (int)(width);
                int newHeight = (int)(height);

                Bitmap newImage = new Bitmap(newWidth, newHeight);

                for (int y = 0; y < modified.Height; y++)
                {
                    for (int x = 0; x < newWidth; x++)
                    {
                        int curY = (y + scrollPosition);

                        int pixelOffset = 4 + (curY * width * 2) + (x * 2);
                        ushort pixelValue = BitConverter.ToUInt16(image, pixelOffset);

                        int brightness = BitConverter.ToUInt16(image, pixelOffset) & 0x3FF;

                        int scaledBrightness = 255;

                        if (modificate)
                        {
                            scaledBrightness = calculateBrightness(pixelValue);
                        } 
                        else {
                            scaledBrightness = (brightness >> 0) & 0xFF;
                        }
                   

                        Color pixelColor = Color.FromArgb(scaledBrightness, scaledBrightness, scaledBrightness);
                        newImage.SetPixel(x, y, pixelColor);
                    }
                }
                return newImage;
            }
            return null;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (modified.Image != null)
            {
                scrollPosition = e.NewValue * (height - modified.Height) / vScrollBar1.Maximum;
                
            }

            modified.Image = getImage(_fileData, true);
            original.Image = getImage(_fileData);
        }

        private void TrackBar_Scroll(object sender, EventArgs e)
        {
            System.Windows.Forms.TrackBar trackBar = (System.Windows.Forms.TrackBar)sender;
            int index = int.Parse(trackBar.Name.Replace("trackBar", "")) - 1; // Получаем индекс ползунка
            trackBarValues[index] = trackBar.Value; // Сохраняем значение ползунка
            trackBarLabels[index].Text = trackBar.Value.ToString();

            DrawGraph();
            modified.Image = getImage(_fileData, true);
        }

        private void DrawGraph()
        {
            // Создаем новый Bitmap для рисования графика
            Bitmap bitmap = new Bitmap(diagram.Width, diagram.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.White); // Очищаем фон

                // Задаем фиксированные границы для оси Y
                int minValue = 0; // Минимальное значение
                int maxValue = 250; // Максимальное значение
                int width = diagram.Width;
                int height = diagram.Height;

                // Устанавливаем отступы
                int padding = 60;

                // Рисуем сетку
                DrawGrid(g, width, height);

                // Рисуем линии графика
                for (int i = 0; i < trackBarValues.Length - 1; i++)
                {
                    int x1 = padding + (i * (width - 2 * padding)) / (trackBarValues.Length - 1);
                    int y1 = height - padding - ((trackBarValues[i] - minValue) * (height - 2 * padding) / (maxValue - minValue));
                    int x2 = padding + ((i + 1) * (width - 2 * padding)) / (trackBarValues.Length - 1);
                    int y2 = height - padding - ((trackBarValues[i + 1] - minValue) * (height - 2 * padding) / (maxValue - minValue));

                    g.DrawLine(Pens.Blue, x1, y1, x2, y2);
                }

                // Рисуем оси (по желанию)
                g.DrawLine(Pens.Black, padding, height - padding, width - padding, height - padding); // Ось X
                g.DrawLine(Pens.Black, padding, height - padding, padding, padding); // Ось Y
            }

            // Устанавливаем изображение в PictureBox
            diagram.Image = bitmap;
        }


        private void DrawGrid(Graphics g, int width, int height)
        {
            // Устанавливаем начальное и конечное значения
            int minValue = 0;
            int maxValue = 255;
            int divisions = 9; // Количество делений (включая 0 и 255)

            // Устанавливаем отступы
            int padding = 60;

            // Рассчитываем доступную ширину и высоту
            int availableWidth = width - 2 * padding;
            int availableHeight = height - 2 * padding;

            // Рисуем горизонтальные линии и подписи
            for (int i = 0; i < divisions; i++)
            {
                // Вычисляем текущее значение на основе индекса
                int currentValue = minValue + (maxValue - minValue) * i / (divisions - 1);
                int y = height - padding - (availableHeight * i) / (divisions - 1);
                g.DrawLine(Pens.Green, padding, y, width - padding, y);

                // Рисуем подпись слева
                string label = currentValue.ToString();
                g.DrawString(label, this.Font, Brushes.Black, new PointF(padding - 40, y - 10)); // Смещение для подписи
            }

            // Рисуем вертикальные линии и подписи
            for (int i = 0; i < divisions; i++)
            {
                int x = padding + (availableWidth * i) / (divisions - 1);
                g.DrawLine(Pens.Green, x, padding, x, height - padding);

                // Рисуем подпись снизу
                string label = (minValue + (maxValue - minValue) * i / (divisions - 1)).ToString();
                g.DrawString(label, this.Font, Brushes.Black, new PointF(x - 10, height - padding + 5)); // Смещение для подписи
            }

            // Добавляем подписи к осям
            g.DrawString("Код яркости пикселя", this.Font, Brushes.Black, new PointF(width / 2 - 70, height - padding + 20)); // Подпись оси X

            // Подпись оси Y по одной букве в строку
            string yLabel = "Яркость пикселя";
            float yLabelX = padding - 60; // Положение по X
            float yLabelStartY = height / 2 - (yLabel.Length * this.Font.Height) / 2; // Центрирование по Y

            for (int i = 0; i < yLabel.Length; i++)
            {
                g.DrawString(yLabel[i].ToString(), this.Font, Brushes.Black, new PointF(yLabelX, yLabelStartY + i * this.Font.Height));
            }
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
