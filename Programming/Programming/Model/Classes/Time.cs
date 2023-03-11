using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    class Time
    {   
        private int _hours;

        private int Hours
        {
          get => _hours;
          set
            {
                if (value < 0 || value > 23)
                { 
                    throw new ArgumentException(); 
                }
                _hours = value;
            }
        }

        private int _minutes;

        private int Minutes
        {
            get => _minutes;
            set
            {
                if (value < 0|| value > 59)
                {
                    throw new ArgumentException();
                }
                _minutes = value;
            }
        }

        private int _seconds;

        private int Seconds
        {
            get => _seconds;
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentException();
                }

                _seconds = value;
            }
        }

        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public Time()
        {
             //Hours=;
            //Minutes =;
            //Seconds =;
        }
        // Целочисленное поле Часы (от 0 до 23)
        // Целочисленное поле Минуты (от 0 до 60)
        // Целочисленное поле Секунды (от 0 до 60)
    }
}
