using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlacesApp
{
    class Place
    {
        /// <summary>
        /// Название.
        /// </summary>
        private string _name;

        /// <summary>
        /// Адрес.
        /// </summary>
        private string _address;

        /// <summary>
        /// Рейтинг
        /// </summary>
        private double _rating;

        //не более 200 символов
        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                //Validator.AssertOnPositiveValue(value, "Length");

                _name = value;
            }
        }
        //не более 100 символов
        /// <summary>
        /// 
        /// </summary>
        public string Address
        {
            get => _address;
            set
            {
                //Validator.AssertOnPositiveValue(value, "Length");

                _name = value;
            }
        }

        //перечисления
        /// <summary>
        /// 
        /// </summary>
        public Category Category { get; set; }

        //вещественное число от 0 до 5
        /// <summary>
        /// 
        /// </summary>
        public double Rating
        {
            get => _rating;
            set
            {
                //Validator.AssertOnPositiveValue(value, "Length");

                _rating = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Place"/>.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="address"></param>
        /// <param name="category"></param>
        /// <param name="rating"></param>
        public Place(string name, string address, Category category, double rating)
        {
            Name = name;
            Address = address;
            Category = category;
            Rating = rating;
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Place"/>.
        /// </summary>
        public Place()
        {

        }
    }
}
