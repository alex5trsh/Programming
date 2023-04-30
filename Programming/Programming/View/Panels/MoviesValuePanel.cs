using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Movie = Programming.Model.Classes.Movie;
using Programming.Model.Classes;

namespace Programming.View.Panels
{
    // TODO: XML (+)
    /// <summary>
    /// Предоставляет методы за вывод данных выбранного элемента класса <see cref="Movie"/> и 
    /// их изменения.
    /// </summary>
    public partial class MoviesValuePanel : UserControl
    {
        // TODO: XML (+)
        /// <summary>
        /// Массив, состоящий из 5 элементов, класса <see cref="Movie"/>.
        /// </summary>
        private Movie[] _movies = new Movie[5];

        // TODO: XML (+)
        /// <summary>
        /// Элемент класса <see cref="Movie"/>.
        /// </summary>
        private Movie _currentMovie = new Movie();

        public MoviesValuePanel()
        {
            InitializeComponent();

            string[] names = new string[] { "The Thing", "Arrival", "Mr&Mrs Smith", "Life in a year", "Fight club" };
            int[] durations = new int[] { 103, 118, 126, 107, 139 };
            int[] years = new int[] { 2011, 2016, 2005, 2020, 1999 };
            string[] genres = new string[] { "Horror", "Science fiction", "Action movie", "Drama", "Thriller" };
            double[] raitings = new double[] { 6.4, 7.6, 7.5, 6.9, 8.8 };
            for (int i = 0; i < _movies.Length; i++)
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
                DurationTextBox.BackColor = AppColors.White;
            }
            catch
            {
                DurationTextBox.BackColor = AppColors.Red;
            }
        }

        private void YearOfReleaseTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.YearOfRelease = Convert.ToInt32(YearOfReleaseTextBox.Text);
                YearOfReleaseTextBox.BackColor = AppColors.White;
            }
            catch
            {
                YearOfReleaseTextBox.BackColor = AppColors.Red;
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
                RatingTextBox.BackColor = AppColors.White;
            }
            catch
            {
                RatingTextBox.BackColor = AppColors.Red;
            }
        }

        /// <summary>
        /// Ищет объект с максимальным рейтингом в массиве.
        /// </summary>
        /// <param name="arrayMovies">Имя массива, который подлежит проверке.</param>
        /// <returns>Возвращает индекс элемента массива, у которого максимальный рейтинг.</returns>
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
    }
}
