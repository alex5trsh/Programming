using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    class Validator
    {
        public static void AssertOnPositiveValue(int value, string nameOfFeature)
        { 
            if ( value<1 )
            { 
                throw new ArgumentException("Переменная свойства"+nameOfFeature+"должна быть положительной");
            }
        }

        public static void AssertOnPositiveValue(double value, string nameOfFeature)
        {
            if (value < 1)
            {
                throw new ArgumentException("Переменная свойства" + nameOfFeature + "должна быть положительной");
            }
        }
        public static void AssertValueInRange( int value,  int min, int max, string nameOfFeature )
        {
            if (value < min || value > max)
            {
                throw new ArgumentException("Переменная свойства" + nameOfFeature + "не входит в диапазон");
            }
        }

        public static void AssertValueInRange(double value, double min, double max, string nameOfFeature)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException("Переменная свойства" + nameOfFeature + "не входит в диапазон");
            }
        }

    }
}
