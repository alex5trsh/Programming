using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    class Time
    {
        private int Hours
        {
            //get { }
            set
            {
                if (value < 0 || value > 24)
                { }
            }
        }
        private int Munutes
        {
            //get { }
            set
            {
                if (value < 0|| value > 61)
                { }
            }
        }
        private int Seconds
        {
            //get { }
            set
            {
                if (value < 0 || value > 61)
                { }
            }
        }
        // Целочисленное поле Часы (от 0 до 23)
        // Целочисленное поле Минуты (от 0 до 60)
        // Целочисленное поле Секунды (от 0 до 60)
    }
}
