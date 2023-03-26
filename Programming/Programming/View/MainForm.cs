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
using Rectangle = Programming.Model.Classes.Rectangle;

// TODO: Все TextBox, Label и кнопки сделать ближе к ListBox (+)
// TODO: Сделать верстку адаптивной к размеру окна 
// TODO: Убрать GroupBox. Вместо него сделать Label над ListBox (см. макет) (+)
namespace Programming
{
    public partial class MainForm : Form
    {
	    // TODO: Порядок элементов класса: константы, приватные поля, свойства, конструктор, публичные методы, приватные методы (+)
		private Rectangle[] _rectangles = new Rectangle[5];

        private Rectangle _currentRectangle= new Rectangle();        
        
        private Movie[] _movies = new Movie[5];

        private Movie _currentMovie = new Movie();

        
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
        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
				// TODO: Поменять Double на double (+)
                // TODO: Проверки тут не нужны. Значение проверяется в set свойства. (+)
                _currentRectangle.Length = Convert.ToDouble(LengthTextBox.Text);
                // TODO: else не нужен, так как исключение, в случае ошибки, будет вызываться в set свойства (+)
				// TODO: RSDN (+)
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
                // TODO: Поменять Double на double (+)
                // TODO: Проверки тут не нужны. Значение проверяется в set свойства. (+)
                _currentRectangle.Width = Convert.ToDouble(WidthTextBox.Text);
                // TODO: else не нужен, так как исключение, в случае ошибки, будет вызываться в set свойства (+)
				// TODO: RSDN (+)
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
            for (int i = 0; i < arrayRectangles.Length - 1; i++)
            {
                if (arrayRectangles[i].Width > maxNumber)
                {
                    indexRectangle = i;
                    maxNumber = arrayRectangles[i].Width;
                }
            }
            // TODO: RSDN (+)

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
				// TODO: Поменять Int32 на int (+)
				// TODO: Проверки тут не нужны. Значение проверяется в set свойства. (+)
                _currentMovie.DurationInMinutes = Convert.ToInt32(DurationTextBox.Text);
				// TODO: else не нужен, так как исключение, в случае ошибки, будет вызываться в set свойства (+)
				// TODO: RSDN (+)
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
				// TODO: Поменять Int32 на int (+)
				// TODO: Проверки тут не нужны. Значение проверяется в set свойства. (+)
                _currentMovie.YearOfRelease = Convert.ToInt32(YearOfReleaseTextBox);
				// TODO: else не нужен, так как исключение, в случае ошибки, будет вызываться в set свойства (+)
				// TODO: RSDN (+)
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
				// TODO: Поменять Double на double (+)
				// TODO: Проверки тут не нужны. Значение проверяется в set свойства. (+)
				_currentMovie.Rating = Convert.ToDouble(RatingTextBox.Text);
				// TODO: else не нужен, так как исключение, в случае ошибки, будет вызываться в set свойства (+)
				// TODO: RSDN (+)
                RatingTextBox.BackColor = Color.White;
            }
            catch (ArgumentException)
            {
                RatingTextBox.BackColor = Color.FromArgb(255, 182, 193);
            }
        }

        private int FindMovieWithMaxRating(Movie[] arrayMovies)
        {
            int indexMovie = 0;
            double maxNumber = 0.0;
            for (int i = 0; i < arrayMovies.Length - 1; i++)
            {
                if (arrayMovies[i].Rating > maxNumber)
                {
                    indexMovie = i;
                    maxNumber = arrayMovies[i].Rating;
                }
            }
            // TODO: RSDN (+)

            return indexMovie;
        }
        private void FindMaxRatingButton_Click(object sender, EventArgs e)
        {
            MoviesListBox.SelectedIndex = FindMovieWithMaxRating(_movies);
        }
    }
}
