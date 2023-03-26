using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    class Movie
    {        
        private int _duration;

        private int _yearOfRelease;

        private double _rating;

        public string Name { get; set; }

        public int DurationInMinutes
        { 
            get => _duration;
            set {
                if (value < 0)
                {
                    throw new ArgumentException("Продолжительность не может быть отрицательной");
                }
                // TODO: RSDN (+)

                _duration = value;
            } 
        }

        public int YearOfRelease
        {
            get =>_yearOfRelease;
            set
            {
                if (value < 1900 || value > 2023)
                {
                    throw new ArgumentException("Год выхода определяется в диапазоне от 1900 до 2023");
				}
				// TODO: RSDN (+)

				_yearOfRelease = value;
            }
            
        }

        public string Genre { get; set; }

        public double Rating
        {
            get => _rating;
            set
            {
                if (value<0.0||value>10.1)
                {
                    throw new ArgumentException("Рейтинг определяется в диапазоне от 1 до 10");
				}
				// TODO: RSDN (+)

				_rating = value;
            }
        }

        public Movie(string name, int duration, int yearOfRelease,string genre, double rating)
        {
            Name = name;
            DurationInMinutes = duration;
            YearOfRelease = yearOfRelease;
            Genre = genre;
            Rating = rating;
        }

        public Movie()
        {

        }

    }
}
