using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит методы по проверке введенных данных.
    /// </summary>
    class Validator
    {
        /// <summary>
        /// Проверяет, что число является положительным.
        /// </summary>
        /// <param name="value">Проверяемое число.</param>
        /// <param name="nameOfFeature">Имя свойства, которое подлежит проверке.</param>
        public static void AssertOnPositiveValue(int value, string nameOfFeature)
        { 
            if ( value<0 )
            { 
                throw new ArgumentException("Переменная свойства "+nameOfFeature+" должна быть положительной");
            }
        }

        /// <summary>
        /// Проверяет, что вещественное число является положительным.
        /// </summary>
        /// <param name="value">Проверяемое число.</param>
        /// <param name="nameOfFeature">Имя свойства, которое подлежит проверке.</param>
        public static void AssertOnPositiveValue(double value, string nameOfFeature)
        {
            if (value < 1)
            {
                throw new ArgumentException("Переменная свойства " + nameOfFeature + " должна быть положительной");
            }
        }

        /// <summary>
        /// Проверяет, что число входит в диапазон.
        /// </summary>
        /// <param name="value">Проверяемое число.</param>
        /// <param name="min">Начало диапазона.</param>
        /// <param name="max">Конец диапазона.</param>
        /// <param name="nameOfFeature">Имя свойства, которое подлежит проверке.</param>
        public static void AssertValueInRange( int value,  int min, int max, string nameOfFeature )
        {
            if (value < min || value > max)
            {
                throw new ArgumentException("Переменная свойства" + nameOfFeature + "не входит в диапазон");
            }
        }

        /// <summary>
        /// Проверяет, что вещественное число входит в диапазон.
        /// </summary>
        /// <param name="value">Проверяемое число.</param>
        /// <param name="min">Начало диапазона.</param>
        /// <param name="max">Конец диапазона.</param>
        /// <param name="nameOfFeature">Имя свойства, которое подлежит проверке.</param>
        public static void AssertValueInRange(double value, double min, double max, string nameOfFeature)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException("Переменная свойства" + nameOfFeature + "не входит в диапазон");
            }
        }
    }
}
