using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPlaces.PlaceModel
{
    /// <summary>
    /// Хранит методы по проверке введенных данных.
    /// </summary>
    class Validator
    {
        /// <summary>
        /// Проверяет, что длина переменной входит в диапазон.
        /// </summary>
        /// <param name="value">Проверяемая длина.</param>
        /// <param name="min">Начало диапазона.</param>
        /// <param name="max">Конец диапазона.</param>
        /// <param name="nameOfFeature">Имя свойства, которое подлежит проверке.</param>
        public static void AssertLengthInRange(int value, int min, int max, string nameOfFeature)
        {
            if (value < min || value > max)
            {
                // TODO: Длинная строка(+)
                throw new ArgumentException("Длина переменной свойства " + nameOfFeature +
                    " не входит в диапазон");
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
                // TODO: Длинная строка(+)
                throw new ArgumentException("Переменная свойства " + nameOfFeature 
                    + " не входит в диапазон");
            }
        }
    }
}
