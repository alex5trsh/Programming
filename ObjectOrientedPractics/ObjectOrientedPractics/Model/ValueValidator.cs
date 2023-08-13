using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит методы по проверке введенных данных.
    /// </summary>
    class ValueValidator
    {

        /// <summary>
        /// Проверяет, что длина строки не превышает максимальную длину.
        /// </summary>
        /// <param name="value">Проверяемая строка</param>
        /// <param name="maxLength">Максимальная длина строки.</param>
        /// <param name="propertyName">Имя свойства, которое подлежит проверке.</param>
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if(value.Length>maxLength)
            {
                throw new ArgumentException(propertyName+" должен быть меньше "+maxLength+" символов.");
            }

        }

        /// <summary>
        /// Проверяет, что вещественное число входит в диапазон.
        /// </summary>
        /// <param name="value">Проверяемое число.</param>
        /// <param name="min">Начало диапазона.</param>
        /// <param name="max">Конец диапазона.</param>
        /// <param name="propertyName">Имя свойства, которое подлежит проверке.</param>
        public static void AssertValueInRange(double value, double min, double max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException("Переменная свойства" + propertyName + "не входит в диапазон");
            }
        }

        /// <summary>
        /// Проверяет, что строка соответствует формату Фамилия Имя Отчество.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="propertyName">Имя свойства, которое подлежит проверке.</param>
        public static void AssertStringOnFullName(string value, string propertyName)
        {
            int count = 0;
            foreach(var s in value)
            {
                if(s==' ')
                { 
                    count++;
                }
            }  
            
            if(count!=2)
            {
                throw new ArgumentException(propertyName + "должно быть написано в формате " +
                    "Фамилия Имя Отчество.");
            }
        }

    }
}
