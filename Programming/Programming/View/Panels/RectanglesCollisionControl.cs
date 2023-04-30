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
    // TODO: XML (+)
    /// <summary>
    /// Предоставляет методы за вывод данных выбранного элемента и вывод на панели всех объектов.
    /// </summary>
    public partial class RectanglesCollisionControl : UserControl
    {
        // TODO: XML (+)
        /// <summary>
        /// Коллекция элементов класса <see cref="Rectangle"/> .
        /// </summary>
        List<Rectangle> _rectangles = new List<Rectangle>();

        // TODO: XML (+)
        /// <summary>
        /// Элемент класса <see cref="Rectangle"/> .
        /// </summary>
        Rectangle _currentRectnagle;

        // TODO: XML (+)
        /// <summary>
        /// Коллекция элементов класса <see cref="Panel"/>.
        /// </summary>
        List<Panel> _rectanglePanels= new List<Panel>();

        public RectanglesCollisionControl()
        {
            InitializeComponent();

            XTextBox.TextChanged += XTextBox_TextChanged;
            YTextBox.TextChanged += YTextBox_TextChanged;
            WidthTextBox.TextChanged += WidthTextBox_TextChanged;
            HeightTextBox.TextChanged += HeightTextBox_TextChanged;
        }

        private void AddRectangleButton_Click(object sender, EventArgs e)
        {
            Rectangle newRectangle = Model.Geometry.RectangleFactory.Randomize();
            _rectangles.Add(newRectangle);
            RectanglesListBox.Items.Add(newRectangle.Id + ": (X= " + newRectangle.Center.X +
                "; Y= " + newRectangle.Center.Y + "; W= " + newRectangle.Width + "; H= "
                + newRectangle.Length + " )");
            Panel _newPanel = new Panel()
            {
                Width = Convert.ToInt32(newRectangle.Width),
                Height = Convert.ToInt32(newRectangle.Length),
                Location = new Point(newRectangle.Center.X - Convert.ToInt32(newRectangle.Width * 0.5), newRectangle.Center.Y - Convert.ToInt32(newRectangle.Length * 0.5))   // y-1/2 высоты x-1/2ширины
            };
            _newPanel.BackColor = AppColors.Green;
            _rectanglePanels.Add(_newPanel);
            RectanglesPanel.Controls.Add(_newPanel);
            FindCollisions(_rectangles);
        }

        private void DeleteRectangleButton_Click(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex >= 0 && RectanglesListBox != null)
            {
                int selectedIndex = RectanglesListBox.SelectedIndex;
                RectanglesListBox.Items.RemoveAt(selectedIndex);
                _rectangles.RemoveAt(selectedIndex);
                RectanglesPanel.Controls.RemoveAt(selectedIndex);
                _rectanglePanels.RemoveAt(selectedIndex);
                ClearRectangleInfo();
            }

            FindCollisions(_rectangles);
        }

        // TODO: Теперь можно переименовать обработчик события (+)
        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex >= 0)
            {
                int chosenIndex = RectanglesListBox.SelectedIndex;
                _currentRectnagle = _rectangles[chosenIndex];
                UpdateRectangleInfo(_currentRectnagle);
            }
        }

    private void XTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_currentRectnagle.Center.X != (int)Convert.ToInt32(XTextBox.Text))
                {
                    int _currentX = Convert.ToInt32(XTextBox.Text);
                    int _currentY = _currentRectnagle.Center.Y;
                    _currentRectnagle.Center = new Model.Geometry.Point2D(_currentX, _currentY);
                    ChangeRectangleOnPanel(RectanglesListBox.SelectedIndex);
                    RectanglesListBox.Items[RectanglesListBox.SelectedIndex] = (_currentRectnagle.Id
                        + ": (X= " + _currentRectnagle.Center.X +
                        "; Y= " + _currentRectnagle.Center.Y + "; W= " + _currentRectnagle.Width + "; H= "
                        + _currentRectnagle.Length + " )");
                }
               
                XTextBox.BackColor = AppColors.White;
            }
            catch
            {
                XTextBox.BackColor =AppColors.Red;
            }
        }

        private void YTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_currentRectnagle.Center.Y != (int)Convert.ToInt32(YTextBox.Text))
                {
                    int _currentY = Convert.ToInt32(YTextBox.Text);
                    int _currentX = _currentRectnagle.Center.X;
                    _currentRectnagle.Center = new Model.Geometry.Point2D(_currentX, _currentY);
                    ChangeRectangleOnPanel(RectanglesListBox.SelectedIndex);
                    FindCollisions(_rectangles);
                    RectanglesListBox.Items[RectanglesListBox.SelectedIndex] = (_currentRectnagle.Id
                        + ": (X= " + _currentRectnagle.Center.X +
                        "; Y= " + _currentRectnagle.Center.Y + "; W= " + _currentRectnagle.Width + "; H= "
                        + _currentRectnagle.Length + " )");
                }
                
                YTextBox.BackColor = AppColors.White;
            }
            catch
            {
                YTextBox.BackColor = AppColors.Red;
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_currentRectnagle.Width != (double)Convert.ToDouble(WidthTextBox.Text))
                {
                    _currentRectnagle.Width = Convert.ToDouble(WidthTextBox.Text);
                    ChangeRectangleOnPanel(RectanglesListBox.SelectedIndex);
                    FindCollisions(_rectangles);
                    RectanglesListBox.Items[RectanglesListBox.SelectedIndex] = (_currentRectnagle.Id
                        + ": (X= " + _currentRectnagle.Center.X +
                        "; Y= " + _currentRectnagle.Center.Y + "; W= " + _currentRectnagle.Width + "; H= "
                        + _currentRectnagle.Length + " )");
                }
                
                WidthTextBox.BackColor = AppColors.White;
            }
            catch
            {
                WidthTextBox.BackColor = AppColors.Red;
            }
        }

        private void HeightTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_currentRectnagle.Length != (double)Convert.ToDouble(HeightTextBox.Text))
                {
                    _currentRectnagle.Length = Convert.ToDouble(HeightTextBox.Text);
                    ChangeRectangleOnPanel(RectanglesListBox.SelectedIndex);
                    FindCollisions(_rectangles);
                    RectanglesListBox.Items[RectanglesListBox.SelectedIndex] = (_currentRectnagle.Id
                        + ": (X= " + _currentRectnagle.Center.X +
                        "; Y= " + _currentRectnagle.Center.Y + "; W= " + _currentRectnagle.Width + "; H= "
                        + _currentRectnagle.Length + " )");
                }
                
                HeightTextBox.BackColor = AppColors.White;
            }
            catch
            {
                HeightTextBox.BackColor = AppColors.Red;
            }
        }

        /// <summary>
        /// Проверяет пересечения объектов и окрашивает их на панели.
        /// </summary>
        /// <param name="rectangles">Имя массива объектов, которое подлежит проверке. </param>
        private void FindCollisions(List<Rectangle> rectangles)
        {
            for (int i = 0; i < rectangles.Count; i++)
            {
                _rectanglePanels[i].BackColor = AppColors.Green;
            }

            for (int i = 0; i < rectangles.Count; i++)
            {
                for (int j = i; j < rectangles.Count; j++)
                {
                    if (Model.Geometry.CollisionManager.IsCollision(rectangles[i], rectangles[j]) && i != j)
                    {
                        _rectanglePanels[i].BackColor = AppColors.Red;
                        _rectanglePanels[j].BackColor = AppColors.Red;
                    }
                }
            }
        }

        /// <summary>
        /// Меняет положение объекта на панели, при изменении данных в текстовых полях.
        /// </summary>
        /// <param name="index">Индекс измененного объекта.</param>
        private void ChangeRectangleOnPanel(int index)
        {
            int width = Convert.ToInt32(_currentRectnagle.Width);
            int height = Convert.ToInt32(_currentRectnagle.Length);
            Point location = new Point(_currentRectnagle.Center.X - Convert.ToInt32(_currentRectnagle.Width * 0.5),
                _currentRectnagle.Center.Y - Convert.ToInt32(_currentRectnagle.Length * 0.5));
            RectanglesPanel.Controls[index].Location = location;
            RectanglesPanel.Controls[index].Size = new Size(width, height);
        }

        /// <summary>
        /// Обновляет данные по указанному объекту в текстовых полях.
        /// </summary>
        /// <param name="rectangle">Название объекта, данные которого необходимо обновить.</param>
        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            IdTextBox.Text = Convert.ToString(rectangle.Id);
            XTextBox.Text = Convert.ToString(rectangle.Center.X);
            YTextBox.Text = Convert.ToString(rectangle.Center.Y);
            WidthTextBox.Text = Convert.ToString(rectangle.Width);
            HeightTextBox.Text = Convert.ToString(rectangle.Length);
        }

        /// <summary>
        /// Очищает все текстовые поля со значениями объекта.
        /// </summary>
        private void ClearRectangleInfo()
        {
            IdTextBox.Clear();
            XTextBox.Clear();
            YTextBox.Clear();
            WidthTextBox.Clear();
            HeightTextBox.Clear();
        }
    }
}
