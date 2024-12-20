﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные об адресах.
    /// </summary>
    public class Address : ICloneable
    {
        /// <summary>
        /// Событие на изменение какого-либо свойства класса <see cref="Address"/>.
        /// </summary>
        public event EventHandler<EventArgs> AddressChanged;

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

                if (_index != value)
                {
                    _index = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
                    
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
                ValueValidator.AssertStringOnLength(value, 1, 50, "Country");

                if (_country != value)
                {
                    _country = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
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
                ValueValidator.AssertStringOnLength(value, 1, 50, "City");

                if (_city != value)
                {
                    _city = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
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
                ValueValidator.AssertStringOnLength(value, 1, 100, "Street");

                if (_street != value)
                {
                    _street = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
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
                ValueValidator.AssertStringOnLength(value, 1, 10, "Building");

                if (_building != value)
                {
                    _building = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
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
                ValueValidator.AssertStringOnLength(value, 1, 10, "Apartment");

                if (_apartment != value)
                {
                    _apartment = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        public override string ToString()
        {
            return $"{Country},{City},{Street},{Building},{Apartment}";
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

        /// <inheritdoc />
        public object Clone()
        {
            return new Address(this.Index, this.Country, this.City, this.Street, this.Building, this.Apartment);
        }

        /// <inheritdoc />
        public override bool Equals(object other)
        {
            if (other == null) 
                return false;

            if (other is Address==false) 
                return false;

            if (object.ReferenceEquals(this, other)) 
                return true;

            var otherAddress= (Address)other;
            return (this.Index == otherAddress.Index); 
        }

        /// <inheritdoc />
        public bool Equals(Address otherAddress)
        {
            if (otherAddress == null)
                return false;

            if (Address.ReferenceEquals(this, otherAddress))
                return true;

            return (this.Index == otherAddress.Index);
        }
    }
}
