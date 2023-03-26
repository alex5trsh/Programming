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

        private int _minutes;

        private int _seconds;

        public int Hours
        {
          get => _hours;
          set
            {
                if (value < 0 || value > 23)
                { 
                    throw new ArgumentException("Часы находятся в диапазоне от 0 до 23");
				}
				// TODO: RSDN
				_hours = value;
            }
        }

        public int Minutes
        {
            get => _minutes;
            set
            {
                if (value < 0|| value > 59)
                {
                    throw new ArgumentException("Минуты находятся в диапазоне от 0 до 59");
				}
				// TODO: RSDN
				_minutes = value;
            }
        }

        public int Seconds
        {
            get => _seconds;
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentException("Секунды находятся в диапазоне от 0 до 59");
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

        }
        
    }
}
