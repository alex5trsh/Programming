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
            set 
            {
                Validator.AssertOnPositiveValue(value, "DurationInMinutes");

                _duration = value;
            } 
        }

        public int YearOfRelease
        {
            get =>_yearOfRelease;
            set
            {
               Validator.AssertValueInRange(value, 1900, 2023, "YearOfRealease");

                _yearOfRelease = value;
            }
            
        }

        public string Genre { get; set; }

        public double Rating
        {
            get => _rating;
            set
            {
                Validator.AssertValueInRange(value, 1, 10, "Rating");

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
