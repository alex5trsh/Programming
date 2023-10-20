using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
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
        public static void AssertStringOnLength(string value, int minLength,int maxLength, 
            string propertyName)
        {
            //if (value == null)
            //{
            //    return;
            //}

            if ( value.Length<minLength||value.Length > maxLength)
            {
                throw new ArgumentException("Длина переменной свойства " + propertyName +
                    " не входит в диапазон");
            }
        }

        /// <summary>
        /// Проверяет, что длина переменной входит в диапазон.
        /// </summary>
        /// <param name="value">Проверяемая длина.</param>
        /// <param name="min">Начало диапазона.</param>
        /// <param name="max">Конец диапазона.</param>
        /// <param name="nameOfFeature">Имя свойства, которое подлежит проверке.</param>
        public static void AssertLengthInRange(int value, int min, int max, string nameOfFeature)
        {
            //if (value == 0)
            //{
            //    return;
            //}

            if (value < min || value > max)
            {
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
        /// <param name="propertyName">Имя свойства, которое подлежит проверке.</param>
        public static void AssertValueInRange(double value, double min, double max, string propertyName)
        {
            //if(value==0)
            //{
            //    return;
            //}  
            
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
