using AppPlaces.PlaceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AppPlaces.PlaceModel
{
    /// <summary>
    /// Хранит данные о заведениях.
    /// </summary>
     public class Place
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

        /// <summary>
        /// Возвращает и задает название. Длина должна быть не более 200 символов.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                Validator.AssertLengthInRange(value.Length, 1, 200, "Name");

                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задает адрес. Длина должна быть не более 100 символов.
        /// </summary>
        public string Address
        {
            get => _address;
            set
            {
                Validator.AssertLengthInRange(value.Length, 1, 100, "Address");

                _address = value;
            }
        }

        /// <summary>
        /// Возвращает и задает категорию.
        /// </summary>
		[JsonConverter(typeof(JsonStringEnumConverter))]
        public Category Category { get; set; }

        /// <summary>
        /// Возвращает и задает рейтинг. Должен состоять только из чисел от 0 до 5.
        /// </summary>
        public double Rating
        {
            get => _rating;
            set
            {
                Validator.AssertValueInRange(value, 0, 5, "Rating");

                _rating = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Place"/>.
        /// </summary>
        /// <param name="name">Название. Длина должна быть не более 200 символов.</param>
        /// <param name="address">Адрес. Длина должна быть не более 100 символов.</param>
        /// <param name="category">Категория.</param>
        /// <param name="rating">Рейтинг. Должен состоять только из чисел от 0 до 5.</param>
        public Place(string name, string address, Category category, double rating)
        {
            Name = name;
            Address = address;
            Category =category;
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

