using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    class Movies
    {
        private string Name { get; set; }
        private int DurationInMinutes
        { 
            //get { }
            set {
                if (value < 0)
                { 
                    //ArgumentException
                 }
            } 
        }
        private int YearOfRelease
        {
            set {
                if (value < 1900 || value > 2023)
                { }  
            }
            //get { }
        }
        private string Genre { get; set; }
        private double Rating
        {
            //get { }
            set {
                if (value<0.0||value>10.0)
                { } }
        }
        // Строковое поле Название
        // Целочисленное поле Продолжительность в минутах
        // Целочисленное поле Год выпуска (от 1900 до текущего года)
        // Строковое поле Жанр
        // Вещественное поле Рейтинг (от 0 до 10)

    }
}
