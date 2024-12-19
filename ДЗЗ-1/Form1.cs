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
            rotationTimer.Interval = 10; // Интервал в миллисекундах (0.1 секунды)
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
        // Применяем текущий уровень увеличения
        int newWidth = (int)(width / observeScalar);
        int newHeight = (int)(height / observeScalar);

        Bitmap newImage = new Bitmap(newWidth, newHeight);

        for (int y = 0; y < newHeight; y++)
        {
            for (int x = 0; x < newWidth; x++)
            {
                // Вычисляем координаты пикселя в исходном изображении
                int sourceX = x * observeScalar;
                int sourceY = y * observeScalar;

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
            // Получаем новые размеры изображения
            Size newSize = GetRotatedSize(angle, img.Size);
            Bitmap rotatedBmp = new Bitmap(newSize.Width, newSize.Height);

            // Создаем матрицу вращения
            Matrix rotationMatrix = new Matrix(-angle);

            // Находим центр нового изображения
            float centerX = pivotX; // Используем заданный центр вращения
            float centerY = pivotY;

            // Проходим по каждому пикселю нового изображения
            for (int y = 0; y < rotatedBmp.Height; y++)
            {
                for (int x = 0; x < rotatedBmp.Width; x++)
                {
                    // Вычисляем смещение относительно центра нового изображения
                    float offsetX = x - centerX;
                    float offsetY = y - centerY;

                    // Преобразуем координаты с использованием матрицы вращения
                    Point transformedPoint = rotationMatrix.TransformPoint(new Point((int)offsetX, (int)offsetY));

                    // Находим исходные координаты в оригинальном изображении
                    float sourceX = transformedPoint.X + centerX;
                    float sourceY = transformedPoint.Y + centerY;

                    // Проверяем, находятся ли новые координаты в пределах оригинального изображения
                    if (sourceX >= 0 && sourceX < img.Width && sourceY >= 0 && sourceY < img.Height)
                    {
                        // Получаем цвета для билинейной интерполяции
                        Color color = BilinearInterpolation(img, sourceX, sourceY);
                        rotatedBmp.SetPixel(x, y, color);
                    }
                }
            }

            return rotatedBmp;
        }


        private Color BilinearInterpolation(Image img, float x, float y)
        {
            // Находим целые координаты и дробные части
            int x1 = (int)Math.Floor(x);
            int y1 = (int)Math.Floor(y);
            int x2 = x1 + 1;
            int y2 = y1 + 1;

            // Получаем цвета пикселей
            Color c1 = (x1 >= 0 && y1 >= 0 && x1 < img.Width && y1 < img.Height) ? ((Bitmap)img).GetPixel(x1, y1) : Color.Empty;
            Color c2 = (x2 >= 0 && y1 >= 0 && x2 < img.Width && y1 < img.Height) ? ((Bitmap)img).GetPixel(x2, y1) : Color.Empty;
            Color c3 = (x1 >= 0 && y2 >= 0 && x1 < img.Width && y2 < img.Height) ? ((Bitmap)img).GetPixel(x1, y2) : Color.Empty;
            Color c4 = (x2 >= 0 && y2 >= 0 && x2 < img.Width && y2 < img.Height) ? ((Bitmap)img).GetPixel(x2, y2) : Color.Empty;

            // Вычисляем дробные части
            float dx = x - x1;
            float dy = y - y1;

            // Интерполяция по X
            Color top = Interpolate(c1, c2, dx);
            Color bottom = Interpolate(c3, c4, dx);

            // Интерполяция по Y
            return Interpolate(top, bottom, dy);
        }

        private Color Interpolate(Color c1, Color c2, float factor)
        {
            if (c1 == Color.Empty && c2 == Color.Empty)
                return Color.Empty;

            int r = (int)(c1.R * (1 - factor) + c2.R * factor);
            int g = (int)(c1.G * (1 - factor) + c2.G * factor);
            int b = (int)(c1.B * (1 - factor) + c2.B * factor);
            return Color.FromArgb(r, g, b);
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

        private Size GetRotatedSize(float angle, Size originalSize)
        {
            double radians = angle * Math.PI / 180;
            double cos = Math.Abs(Math.Cos(radians));
            double sin = Math.Abs(Math.Sin(radians));

            int newWidth = (int)(originalSize.Width * cos + originalSize.Height * sin);
            int newHeight = (int)(originalSize.Width * sin + originalSize.Height * cos);

            return new Size(newWidth, newHeight);
        }

    }

    public class Matrix
    {
        private readonly double cos;
        private readonly double sin;

        public Matrix(double angle)
        {
            double radians = angle * Math.PI / 180;
            cos = Math.Cos(radians);
            sin = Math.Sin(radians);
        }

        public Point TransformPoint(Point point)
        {
            int newX = (int)(point.X * cos - point.Y * sin);
            int newY = (int)(point.X * sin + point.Y * cos);
            return new Point(newX, newY);
        }
    }


}
