using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    class Address
    {
        /// <summary>
        /// Почтовый индекс.
        /// </summary>
        private int _index;

        /// <summary>
        /// Страна.
        /// </summary>
        private string _country;

        /// <summary>
        /// Город.
        /// </summary>
        private string _city;

        /// <summary>
        /// Улица.
        /// </summary>
        private string _street;

        /// <summary>
        /// Номер дома.
        /// </summary>
        private string _building;

        /// <summary>
        /// Номер квартиры.
        /// </summary>
        private string _apartment;

        /// <summary>
        /// Возвращает и задает почтовый индекс. Должен состоять из 6 цифр.
        /// </summary>
        public int Index
        {
            get => _index;
            set
            {
                ValueValidator.AssertLengthInRange(value, 100000, 1000000, "Index");

                _index = value;
            }
        }

        /// <summary>
        /// Возвращает и задает страну. Длина должна быть меньше 50.
        /// </summary>
        public string Country
        {
            get => _country;
            set
            {
                ValueValidator.AssertStringOnLength(value, 0, 50, "Country");

                _country = value;
            }
        }

        /// <summary>
        /// Возвращает и задает город. Длина должна быть меньше 50.
        /// </summary>
        public string City
        {
            get => _city;
            set
            {
                ValueValidator.AssertStringOnLength(value, 0, 50, "City");

                _city = value;
            }
        }

        /// <summary>
        /// Возвращает и задает улицу. Длина должна быть меньше 100.
        /// </summary>
        public string Street
        {
            get => _street;
            set
            {
                ValueValidator.AssertStringOnLength(value, 0, 100, "Street");

                _street = value;
            }
        }

        /// <summary>
        /// Возвращает и задает номер дома. Длина должна быть меньше 10.
        /// </summary>
        public string Building
        {
            get => _building;
            set
            {
                ValueValidator.AssertStringOnLength(value, 0, 10, "Building");

                _building = value;
            }
        }

        /// <summary>
        /// Возвращает и задает номер квартиры. Длина должна быть меньше 10.
        /// </summary>
        public string Apartment
        {
            get => _apartment;
            set
            {
                ValueValidator.AssertStringOnLength(value, 0, 10, "Apartment");

                _apartment = value;
            }
        }

        /// <summary>
        /// Создает экзмепляр класса <see cref="Address"/>.
        /// </summary>
        /// <param name="index">Почтовый индекс. Должен состоять из 6 цифр.</param>
        /// <param name="country">Страна. Длина должна быть меньше 50.</param>
        /// <param name="city">Город. Длина должна быть меньше 50.</param>
        /// <param name="street">Улица. Длина должна быть меньше 100.</param>
        /// <param name="building">Дом. Длина должна быть меньше 10.</param>
        /// <param name="apartment">Номер квартиры. Длина должна быть меньше 10.</param>
        public Address(int index, string country, string city, string street, string building,
            string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Address"/>.
        /// </summary>
        public Address()
        {

        }

    }
}
