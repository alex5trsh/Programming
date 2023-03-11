using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    class Movies
    {
        private string Name { get; set; }

        private int _duration;
        private int Duration
        { 
            get => _duration;
            set {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                _duration = value;
            } 
        }
        private int _yearOfRelease;

        private int YearOfRelease
        {
            get =>_yearOfRelease;
            set
            {
                if (value < 1900 || value > 2023)
                {
                    throw new ArgumentException();
                }
                _yearOfRelease = value;
            }
            
        }

        private string Genre { get; set; }

        private double _rating;

        private double Rating
        {
            get => _rating;
            set
            {
                if (value<0.0||value>10.1)
                {
                    throw new ArgumentException();
                }
                _rating = value;
            }
        }

        public Movies(string name, int duration, int yearOfRelease,string genre, double rating)
        {
            Name = name;
            Duration = duration;
            YearOfRelease = yearOfRelease;
            Genre = genre;
            Rating = rating;
        }
        // Строковое поле Название
        // Целочисленное поле Продолжительность в минутах
        // Целочисленное поле Год выпуска (от 1900 до текущего года)
        // Строковое поле Жанр
        // Вещественное поле Рейтинг (от 0 до 10)

    }
}
