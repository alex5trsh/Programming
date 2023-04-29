using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о фильмах.
    /// </summary>
    class Movie
    {        
        /// <summary>
        /// Продолжительность.
        /// </summary>
        private int _duration;

        /// <summary>
        /// Год выпуска.
        /// </summary>
        private int _yearOfRelease;

        /// <summary>
        /// Рейтинг.
        /// </summary>
        private double _rating;

        /// <summary>
        /// Возвращает и задает название.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задает продолжительность. Должно состоять только из положительных чисел.
        /// </summary>
        public int DurationInMinutes
        { 
            get => _duration;
            set 
            {
                Validator.AssertOnPositiveValue(value, "DurationInMinutes");

                _duration = value;
            } 
        }

        /// <summary>
        /// Возвращает и задает год выпуска. Должен состоять только из чисел от 1900 до 2023.
        /// </summary>
        public int YearOfRelease
        {
            get =>_yearOfRelease;
            set
            {
               Validator.AssertValueInRange(value, 1900, 2023, "YearOfRealease");

                _yearOfRelease = value;
            }
        }

        /// <summary>
        /// Возвращает и задает жанр.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Возвращает и задает рейтинг. Должен состоять только из вещественных чисел от 1 до 10.
        /// </summary>
        public double Rating
        {
            get => _rating;
            set
            {
                Validator.AssertValueInRange(value, 1, 10, "Rating");

                _rating = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Movie"/>.
        /// </summary>
        /// <param name="name">Название.</param>
        /// <param name="duration">Продолжительность. Должно состоять только из положительных чисел.</param>
        /// <param name="yearOfRelease">Год выпуска. Должен состоять только из чисел от 1900 до 2023.</param>
        /// <param name="genre">Жанр.</param>
        /// <param name="rating">Рейтинг. Должен состоять только из вещественных чисел от 1 до 10.</param>
        public Movie(string name, int duration, int yearOfRelease,string genre, double rating)
        {
            Name = name;
            DurationInMinutes = duration;
            YearOfRelease = yearOfRelease;
            Genre = genre;
            Rating = rating;
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Movie"/>.
        /// </summary>
        public Movie()
        {

        }
    }
}
