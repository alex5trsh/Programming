using Programming.Model.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rectangle = Programming.Model.Geometry.Rectangle;

namespace Programming
{
    public partial class MainForm : Form
    {
		private Rectangle[] _rectangles = new Rectangle[5];

        private Rectangle _currentRectangle;        
        
        private Movie[] _movies = new Movie[5];

        private Movie _currentMovie = new Movie();

        List<Rectangle> _rectangles5=new List<Rectangle>();

        Rectangle _currentRectnagle5;

        List<Panel> _rectanglePanels =new List<Panel>();

        public MainForm()
        {
            InitializeComponent();
            object[] enums = new object[] { typeof(Colors),typeof(EducationForm), typeof(Genre),typeof(Manufactures), typeof(Season),typeof(Weekday) };
            EnumsListBox.Items.AddRange(enums);
            var seasons = Enum.GetValues(typeof(Season));
            foreach(var value in seasons)
            {
                SeasonsComboBox.Items.Add(value);
            }
            //rectangles
            Random run = new Random();
            string[] colors = new string[] { "Green", "Red", "Yellow", "Black", "Blue" };
            for (int i = 0; i <_rectangles.Length; i++)
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
            var namesRectangles = new List<string>() {"Rectangle 1", "Rectangle 2", "Rectangle 3" , "Rectangle 4" , "Rectangle 5" };
            foreach (var item in namesRectangles)
            {
                RectanglesListBox.Items.Add(item);
            }
            LengthTextBox.TextChanged += LengthTextBox_TextChanged;
            WidthTextBox.TextChanged += WidthTextBox_TextChanged;
            ColorTextBox.TextChanged += ColorTextBox_TextChanged;
            //movies
            string[] names = new string[] {"The Thing", "Arrival","Mr&Mrs Smith", "Life in a year","Fight club" };
            int[] durations = new int[] {103, 118, 126, 107, 139};
            int[] years = new int[] {2011, 2016, 2005, 2020, 1999};
            string[] genres = new string[] {"Horror","Science fiction", "Action movie", "Drama", "Thriller"};
            double[] raitings = new double[] {6.4, 7.6, 7.5, 6.9, 8.8};
            for(int i=0; i<_movies.Length; i++)
            {
                _movies[i] = new Movie();
                _movies[i].Name = names[i];
                _movies[i].DurationInMinutes = durations[i];
                _movies[i].YearOfRelease = years[i];
                _movies[i].Genre = genres[i];
                _movies[i].Rating = raitings[i];
            }
            MoviesListBox.Items.AddRange(names);
            DurationTextBox.TextChanged += DurationTextBox_TextChanged;
            YearOfReleaseTextBox.TextChanged += YearOfReleaseTextBox_TextChanged;
            GenreTextBox.TextChanged += GenreTextBox_TextChanged;
            RatingTextBox.TextChanged += RatingTextBox_TextChanged;

            X5TextBox.TextChanged += X5TextBox_TextChanged;
            Y5TextBox.TextChanged += Y5TextBox_TextChanged;
            Width5TextBox.TextChanged += Width5TextBox_TextChanged;
            Height5TextBox.TextChanged += Height5TextBox_TextChanged;
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedEnum = (Type)EnumsListBox.SelectedItem;
            var enumValues = Enum.GetValues(selectedEnum);
            ValueListBox.Items.Clear();
            IntValueTextBox.Clear();
            foreach (var enumValue in enumValues)
            { 
                ValueListBox.Items.Add(enumValue); 
            }
        }

        private void ValueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntValueTextBox.Text = Convert.ToString((int)ValueListBox.SelectedItem);
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {   var writtingValue = TypeValueTextBox.Text;
            if (Enum.TryParse(writtingValue, out Weekday gettingValue))
            { 
                WriteTextBox.Text = ($"Это день недели ({ gettingValue}={ (int)gettingValue +1})"); 
            }
            else
            {
                WriteTextBox.Text = "Нет такого дня недели"; 
            }

        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            EnumsTabPage.BackColor = Color.White;
            WriteTextBox.BackColor = Color.White;
            //
            EnumsListBox.BackColor = Color.White;
            ValueListBox.BackColor = Color.White;
            IntValueTextBox.BackColor = Color.White;
            TypeValueTextBox.BackColor = Color.White;
            SeasonsComboBox.BackColor = Color.White;
            var selectedSeason = SeasonsComboBox.SelectedItem;
            switch (selectedSeason)
            {
                case Season.Winter:
                    MessageBox.Show(
                        "Бррр, Холодно!!!",
                        "Winter",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RightAlign
                        );
                    break;
                case Season.Spring:
                    //Основной фон
                    this.BackColor = Color.FromArgb(71,167,106);
                    EnumsTabPage.BackColor = Color.FromArgb(71, 167, 106);
                    WriteTextBox.BackColor = Color.FromArgb(71, 167, 106);
                    //Фон боксов
                    EnumsListBox.BackColor = Color.FromArgb(168, 228, 160);
                    ValueListBox.BackColor = Color.FromArgb(168, 228, 160);
                    IntValueTextBox.BackColor = Color.FromArgb(168, 228, 160);
                    TypeValueTextBox.BackColor = Color.FromArgb(168, 228, 160);
                    SeasonsComboBox.BackColor = Color.FromArgb(168, 228, 160);
                    break;
                case Season.Summer:
                    MessageBox.Show(
                        "Ура! Лето!",
                        "Summer",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RightAlign
                        );
                    break;
                case Season.Autumn:
                    //Основной фон
                    this.BackColor = Color.FromArgb(237,118,14);
                    EnumsTabPage.BackColor = Color.FromArgb(237, 118, 14);
                    WriteTextBox.BackColor = Color.FromArgb(237, 118, 14);
                    //Фон боксов
                    EnumsListBox.BackColor = Color.FromArgb(255, 204, 153);
                    ValueListBox.BackColor = Color.FromArgb(255, 204, 153);
                    IntValueTextBox.BackColor = Color.FromArgb(255, 204, 153);
                    TypeValueTextBox.BackColor = Color.FromArgb(255, 204, 153);
                    SeasonsComboBox.BackColor = Color.FromArgb(255, 204, 153);
                    break;
            }
            

        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var indexOfRectangle= RectanglesListBox.SelectedIndex;
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
                LengthTextBox.BackColor = Color.White;
            }
            catch 
            {
                LengthTextBox.BackColor = Color.FromArgb(255, 182, 193);
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
			{
                _currentRectangle.Width = Convert.ToDouble(WidthTextBox.Text);
                WidthTextBox.BackColor = Color.White;
            }
            catch 
            {
                WidthTextBox.BackColor = Color.FromArgb(255, 182, 193);
            }
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
	        _currentRectangle.Color = ColorTextBox.Text;
        }

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

        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var indexOfMovie = MoviesListBox.SelectedIndex;
            _currentMovie = _movies[indexOfMovie];
            DurationTextBox.Text = Convert.ToString(_currentMovie.DurationInMinutes);
            YearOfReleaseTextBox.Text = Convert.ToString(_currentMovie.YearOfRelease);
            GenreTextBox.Text = Convert.ToString(_currentMovie.Genre);
            RatingTextBox.Text = Convert.ToString(_currentMovie.Rating);
        }

        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
			{
                _currentMovie.DurationInMinutes = Convert.ToInt32(DurationTextBox.Text);
                DurationTextBox.BackColor = Color.White;
            }
            catch 
            {
                DurationTextBox.BackColor = Color.FromArgb(255, 182, 193);
            }
        }

        private void YearOfReleaseTextBox_TextChanged(object sender, EventArgs e)
        {
            try
			{
                _currentMovie.YearOfRelease = Convert.ToInt32(YearOfReleaseTextBox.Text);
                YearOfReleaseTextBox.BackColor = Color.White;
            }
            catch 
            {
                YearOfReleaseTextBox.BackColor = Color.FromArgb(255, 182, 193);
            }

        }

        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Genre = GenreTextBox.Text;
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
			{
				_currentMovie.Rating = Convert.ToDouble(RatingTextBox.Text); 
                RatingTextBox.BackColor = Color.White;
            }
            catch
            {
                RatingTextBox.BackColor = Color.FromArgb(255, 182, 193);
            }
        }

        private int FindMovieWithMaxRating(Movie[] arrayMovies)
        {
            int indexMovie = 0;
            double maxNumber = 0.0;
            for (int i = 0; i < arrayMovies.Length; i++)
            {
                if (arrayMovies[i].Rating > maxNumber)
                {
                    indexMovie = i;
                    maxNumber = arrayMovies[i].Rating;
                }
            }

            return indexMovie;
        }
        private void FindMaxRatingButton_Click(object sender, EventArgs e)
        {
            MoviesListBox.SelectedIndex = FindMovieWithMaxRating(_movies);
        }

        private void AddRectangleButton_Click(object sender, EventArgs e)
        {
            Random run = new Random();
            Rectangle newRectangle = new Rectangle();
            newRectangle.Length = Math.Round(1 + run.NextDouble() * 99);
            newRectangle.Width = Math.Round(1 + run.NextDouble() * 99);
            int x = run.Next(1,300);
            int y = run.Next(1,300);
            newRectangle.Center = new Model.Geometry.Point2D(x, y);
            _rectangles5.Add(newRectangle);
            Rectangles5ListBox.Items.Add(newRectangle.Id + ": (X= " + newRectangle.Center.X + "; Y= " + newRectangle.Center.Y
                    + "; W= " + newRectangle.Width + "; H= " + newRectangle.Length+" )");
            Panel _newPanel= new Panel()
            {
                Width = Convert.ToInt32(newRectangle.Width),
                Height = Convert.ToInt32(newRectangle.Length),
                Location = new Point(newRectangle.Center.X - Convert.ToInt32(newRectangle.Width * 0.5), newRectangle.Center.Y - Convert.ToInt32(newRectangle.Length * 0.5))   // y-1/2 высоты x-1/2ширины
            };
            _newPanel.BackColor = Color.FromArgb(127, 127, 255, 127);
            _rectanglePanels.Add(_newPanel);
            RectanglesPanel.Controls.Add(_newPanel);
            FindCollisions(_rectangles5);
        }

        private void DeleteRectangleButton_Click(object sender, EventArgs e) 
        {
            if(Rectangles5ListBox.SelectedIndex>0 & Rectangles5ListBox != null) 
            {
                int selectedIndex = Rectangles5ListBox.SelectedIndex;
                Rectangles5ListBox.Items.RemoveAt(selectedIndex);
                _rectangles5.RemoveAt(selectedIndex);
                RectanglesPanel.Controls.RemoveAt(selectedIndex);
                _rectanglePanels.RemoveAt(selectedIndex);
            }
            FindCollisions(_rectangles5);
        }

        private void Rectangles5ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Rectangles5ListBox.SelectedIndex > 0)
            {
                int chosenIndex = Rectangles5ListBox.SelectedIndex;
                _currentRectnagle5 = _rectangles5[chosenIndex];
                Id5TextBox.Text = Convert.ToString(_currentRectnagle5.Id);
                X5TextBox.Text = Convert.ToString(_currentRectnagle5.Center.X);
                Y5TextBox.Text = Convert.ToString(_currentRectnagle5.Center.Y);
                Width5TextBox.Text = Convert.ToString(_currentRectnagle5.Width);
                Height5TextBox.Text = Convert.ToString(_currentRectnagle5.Length);
            }
        }

        private void X5TextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int _currentX= Convert.ToInt32(X5TextBox.Text);
                int _currentY = _currentRectnagle5.Center.Y;
                _currentRectnagle5.Center = new Model.Geometry.Point2D(_currentX, _currentY);
                ChangeRectangleOnPanel(Rectangles5ListBox.SelectedIndex);
                FindCollisions(_rectangles5);
                X5TextBox.BackColor = Color.White;
            }
            catch
            {
   
                X5TextBox.BackColor = Color.FromArgb(255, 182, 193);
            }
        }

        private void Y5TextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int _currentY = Convert.ToInt32(Y5TextBox.Text);
                int _currentX = _currentRectnagle5.Center.X;
                _currentRectnagle5.Center = new Model.Geometry.Point2D(_currentX, _currentY);
                ChangeRectangleOnPanel(Rectangles5ListBox.SelectedIndex);
                FindCollisions(_rectangles5);
                Y5TextBox.BackColor = Color.White;
            }
            catch
            {
                Y5TextBox.BackColor = Color.FromArgb(255, 182, 193);
            }
        }

        private void Width5TextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectnagle5.Width = Convert.ToDouble(Width5TextBox.Text);
                ChangeRectangleOnPanel(Rectangles5ListBox.SelectedIndex);
                FindCollisions(_rectangles5);
                Width5TextBox.BackColor = Color.White;
            }
            catch
            {
                Width5TextBox.BackColor = Color.FromArgb(255, 182, 193);
            }
        }

        private void Height5TextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectnagle5.Length = Convert.ToDouble(Height5TextBox.Text);
                ChangeRectangleOnPanel(Rectangles5ListBox.SelectedIndex);
                FindCollisions(_rectangles5);
                Height5TextBox.BackColor = Color.White;
            }
            catch
            {
                Height5TextBox.BackColor = Color.FromArgb(255, 182, 193);
            }
        }

        private void FindCollisions(List<Rectangle> rectangles)
        {
            for (int i = 0; i < rectangles.Count; i++)
            {
                _rectanglePanels[i].BackColor = Color.FromArgb(127, 127, 255, 127); 
            }
            for (int i=0; i< rectangles.Count; i++)
            {
                for(int j=i; j<rectangles.Count; j++)
                {
                    if (Model.Geometry.CollisionManager.IsCollision(rectangles[i], rectangles[j]) == true & i!=j)
                    {
                        _rectanglePanels[i].BackColor = Color.FromArgb(127, 255,127, 127);
                        _rectanglePanels[j].BackColor= Color.FromArgb(127, 255, 127, 127);

                    }
                }
            }
        }

        private void ChangeRectangleOnPanel(int index)
        {
            Panel _newPanel = new Panel()
            {
                Width = Convert.ToInt32(_currentRectnagle5.Width),
                Height = Convert.ToInt32(_currentRectnagle5.Length),
                Location = new Point(_currentRectnagle5.Center.X - Convert.ToInt32(_currentRectnagle5.Width * 0.5),
                _currentRectnagle5.Center.Y - Convert.ToInt32(_currentRectnagle5.Length * 0.5))  
            };
            
            _newPanel.BackColor = Color.FromArgb(127, 127, 255, 127);
            RectanglesPanel.Controls.Remove(_rectanglePanels[index]);
            _rectanglePanels.Insert(index, _newPanel); 
            RectanglesPanel.Controls.Add(_rectanglePanels[index]);
        }
        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            Id5TextBox.Text = Convert.ToString(rectangle.Id);
            X5TextBox.Text = Convert.ToString(rectangle.Center.X);
            Y5TextBox.Text = Convert.ToString(rectangle.Center.Y);
            Width5TextBox.Text = Convert.ToString(rectangle.Width);
            Height5TextBox.Text = Convert.ToString(rectangle.Length);
        }

        private void ClearRectangleInfo()
        {
            Id5TextBox.Clear();
            X5TextBox.Clear();
            Y5TextBox.Clear();
            Width5TextBox.Clear();
            Height5TextBox.Clear();
        }
    }
}
