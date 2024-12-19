using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ДЗЗ_1
{
    public partial class Form1 : Form
    {
        private byte[] _fileData;
        private int width;
        private int height;
        private decimal angle;
        private Bitmap originalBitmap;
        private bool isObserved;
        private System.Windows.Forms.Timer rotationTimer;
        private bool isRotating = false;
        private float rotationSpeed = 5f; // Скорость вращения, градусы за вызов

        private float pivotX;
        private float pivotY;

        public Form1()
        {
            InitializeComponent();

            rotationTimer = new System.Windows.Forms.Timer();
            rotationTimer.Interval = 100; // Интервал в миллисекундах (0.1 секунды)
            rotationTimer.Tick += RotationTimer_Tick;
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
                    isObserved = false;
                    listView1.Columns.Add("Файл");
                    ListViewItem item = new ListViewItem(openFileDialog1.FileName);
                    listView1.Items.Add(item);
                    pivotX = 0;
                    pivotY = 0;


                    listView1.Columns[0].Width = (int)(listView1.Width * 1);

                    originalBitmap = getImage(_fileData);
                    picture.Image = originalBitmap;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading file: " + ex.Message);
                }

            }
        }

        private Bitmap getImage(byte[] image, int observeScalar = 1)
        {
            if (image != null)
            {
                // Apply the current zoom level
                int newWidth = (int)(width);
                int newHeight = (int)(height);

                Bitmap newImage = new Bitmap(newWidth, newHeight);

                for (int y = 0; y < picture.Height; y++)
                {
                    for (int x = 0; x < newWidth; x++)
                    {
                        // Вычисляем координаты пикселя в исходном изображении
                        int sourceX = x * observeScalar;
                        int sourceY = y * observeScalar; // Добавляем scrollPosition, если это необходимо

                        // Проверяем, что координаты находятся в пределах изображения
                        if (sourceX < width && sourceY < height)
                        {
                            int pixelOffset = 4 + (sourceY * width * 2) + (sourceX * 2);
                            ushort pixelValue = BitConverter.ToUInt16(image, pixelOffset);

                            int brightness = pixelValue & 0x3FF;

                            // Преобразуем яркость в диапазон от 0 до 255
                            int scaledBrightness = (brightness >> 0) & 0xFF;

                            Color pixelColor = Color.FromArgb(scaledBrightness, scaledBrightness, scaledBrightness);
                            newImage.SetPixel(x, y, pixelColor);
                        }
                    }
                }
                return newImage;
            }
            return null;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            angle = numericUpDown1.Value;
        }

        private void buttonRotateStep_Click(object sender, EventArgs e)
        {
            if (picture.Image != null)
            {
                // Поворачиваем изображение на заданный угол
                Bitmap rotatedImage = RotateImage(originalBitmap, (float)angle);
                picture.Image = rotatedImage;
            }
        }

        private Bitmap RotateImage(Image img, float angle)
        {
            // Создаем новый Bitmap для хранения повернутого изображения
            Bitmap rotatedBmp = new Bitmap(img.Width, img.Height);

            using (Graphics g = Graphics.FromImage(rotatedBmp))
            {
                // Устанавливаем точку вращения в заданные координаты
                g.TranslateTransform(pivotX, pivotY);
                g.RotateTransform(angle);
                g.TranslateTransform(-pivotX, -pivotY);

                // Рисуем оригинальное изображение на новом Bitmap
                g.DrawImage(img, new Point(0, 0));
            }

            return rotatedBmp;
        }

        private void observ_CheckedChanged(object sender, EventArgs e)
        {
            if (isObserved)
            {
                originalBitmap = getImage(_fileData, 1);
                Bitmap rotatedImage = RotateImage(originalBitmap, (float)angle);
                picture.Image = rotatedImage;
            }
            else
            {
                originalBitmap = getImage(_fileData, 6);
                Bitmap rotatedImage = RotateImage(originalBitmap, (float)angle);
                picture.Image = rotatedImage;
            }
            isObserved = !isObserved;
        }

        private void picture_MouseClick(object sender, MouseEventArgs e)
        {
            // Задаем координаты центра вращения на основе клика мыши
            pivotX = e.X;
            pivotY = e.Y;

            xCord.Text = "x: " + pivotX;
            yCord.Text = "y: " + pivotY;
        }

        private void RotationTimer_Tick(object sender, EventArgs e)
        {
            if (picture.Image != null)
            {
                // Увеличиваем угол поворота, приводя rotationSpeed к decimal
                angle += (decimal)rotationSpeed;

                // Проверяем, не превышает ли угол 360 градусов
                if (angle >= 360m)
                {
                    angle -= 360m; // Сбрасываем угол
                }

                // Поворачиваем изображение
                Bitmap rotatedImage = RotateImage(originalBitmap, (float)angle); // Приводим angle к float для метода
                picture.Image = rotatedImage;
            }
        }

        private void buttonRotateAuto_Click(object sender, EventArgs e)
        {
            if (isRotating)
            {
                // Остановить вращение
                rotationTimer.Stop();
                buttonRotateAuto.Text = "Запустить автоматическое вращение"; // Измените текст кнопки
            }
            else
            {
                // Запустить вращение
                rotationTimer.Start();
                buttonRotateAuto.Text = "Остановить автоматическое вращение"; // Измените текст кнопки
            }
            isRotating = !isRotating; // Переключаем состояние
        }
    }

    public class Matrix
    {
        private double[,] elements;

        public Matrix(int rows, int cols)
        {
            elements = new double[rows, cols];
        }

        public double this[int row, int col]
        {
            get => elements[row, col];
            set => elements[row, col] = value;
        }

        public static Matrix CreateRotationMatrix(double angle)
        {
            Matrix rotationMatrix = new Matrix(3, 3);
            double radians = angle * Math.PI / 180;

            rotationMatrix[0, 0] = Math.Cos(radians);
            rotationMatrix[0, 1] = -Math.Sin(radians);
            rotationMatrix[1, 0] = Math.Sin(radians);
            rotationMatrix[1, 1] = Math.Cos(radians);
            rotationMatrix[2, 2] = 1;

            return rotationMatrix;
        }

        public Point TransformPoint(Point point)
        {
            double x = point.X * this[0, 0] + point.Y * this[0, 1];
            double y = point.X * this[1, 0] + point.Y * this[1, 1];
            return new Point((int)x, (int)y);
        }
    }

}
