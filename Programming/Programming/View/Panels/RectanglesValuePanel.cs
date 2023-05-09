using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rectangle = Programming.Model.Geometry.Rectangle;
using Programming.Model.Classes;

namespace Programming.View.Panels
{
    /// <summary>
    /// Предоставляет методы за вывод данных выбранного элемента класса <see cref="Rectangle"/> 
    /// и их изменения.
    /// </summary>
    public partial class RectanglesValuePanel : UserControl
    {
        /// <summary>
        /// Массив, состоящий из 5 элементов, класса <see cref="Rectangle"/>.
        /// </summary>
        private Rectangle[] _rectangles = new Rectangle[5];

        /// <summary>
        /// Элемент класса <see cref="Rectangle"/>.
        /// </summary>
        private Rectangle _currentRectangle;

        public RectanglesValuePanel()
        {
            InitializeComponent();

            Random run = new Random();
            string[] colors = new string[] { "Green", "Red", "Yellow", "Black", "Blue" };
            for (int i = 0; i < _rectangles.Length; i++)
            {
                _rectangles[i] = new Rectangle();
                _rectangles[i].Length = 1 + run.NextDouble() * 99;
                _rectangles[i].Width = 1 + run.NextDouble() * 99;
                int numbercolor = run.Next(1, colors.Length);
                _rectangles[i].Color = colors[numbercolor];
                int x = run.Next(100);
                int y = run.Next(100);
                _rectangles[i].Center = new Model.Geometry.Point2D(x, y);
            }
            var namesRectangles = new List<string>() { "Rectangle 1", "Rectangle 2", "Rectangle 3", "Rectangle 4", "Rectangle 5" };
            foreach (var item in namesRectangles)
            {
                RectanglesListBox.Items.Add(item);
            }

            LengthTextBox.TextChanged += LengthTextBox_TextChanged;
            WidthTextBox.TextChanged += WidthTextBox_TextChanged;
            ColorTextBox.TextChanged += ColorTextBox_TextChanged;
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var indexOfRectangle = RectanglesListBox.SelectedIndex;
            _currentRectangle = _rectangles[indexOfRectangle];
            LengthTextBox.Text = Convert.ToString(_currentRectangle.Length);
            WidthTextBox.Text = Convert.ToString(_currentRectangle.Width);
            ColorTextBox.Text = Convert.ToString(_currentRectangle.Color);
            XTextBox.Text = Convert.ToString(_currentRectangle.Center.X);
            YTextBox.Text = Convert.ToString(_currentRectangle.Center.Y);
            IdTextBox.Text = Convert.ToString(_currentRectangle.Id);
        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Length = Convert.ToDouble(LengthTextBox.Text);
                LengthTextBox.BackColor = AppColors.White;
            }
            catch
            {
                LengthTextBox.BackColor = AppColors.Red;
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Width = Convert.ToDouble(WidthTextBox.Text);
                WidthTextBox.BackColor = AppColors.White;
            }
            catch
            {
                WidthTextBox.BackColor = AppColors.Red;
            }
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = ColorTextBox.Text;
        }

        /// <summary>
        /// Ищет объект с максимальной шириной в массиве.
        /// </summary>
        /// <param name="arrayRectangles">Имя массива, который подлежит проверке.</param>
        /// <returns>Возвращает индекс элемента массива, у которого максимальная ширина.</returns>
        private int FindRectangleWithMaxWidth(Rectangle[] arrayRectangles)
        {
            int indexRectangle = 0;
            double maxNumber = 0.0;
            for (int i = 0; i < arrayRectangles.Length; i++)
            {
                if (arrayRectangles[i].Width > maxNumber)
                {
                    indexRectangle = i;
                    maxNumber = arrayRectangles[i].Width;
                }
            }

            return indexRectangle;
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }
    }
}
