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
                Validator.AssertValueInRange(value, 0, 23, "Hours");

                _hours = value;
            }
        }

        public int Minutes
        {
            get => _minutes;
            set
            {
                Validator.AssertValueInRange(value, 0, 59, "Minutes");

                _minutes = value;
            }
        }

        public int Seconds
        {
            get => _seconds;
            set
            {
                Validator.AssertValueInRange(value, 0, 59, "Seconds");

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
