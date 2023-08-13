using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о покупателях.
    /// </summary>
    class Customer
    {
        /// <summary>
        /// Счетчик товаров.
        /// </summary>
        private static int _allItemsCount;

        /// <summary>
        /// Полное имя.
        /// </summary>
        private string _fullname;

        /// <summary>
        /// Адрес.
        /// </summary>
        private string _address;

        /// <summary>
        /// Возвращает и задает полное имя в формате Фамилия Имя Отчество. 
        /// Длина должна быть меньше 200 символов. 
        /// </summary>
        public string FullName
        {
            get => _fullname;
            set
            {
                ValueValidator.AssertStringOnFullName(value, "FullName");
                ValueValidator.AssertStringOnLength(value, 200, "FullName");
                _fullname = value;
            }
        }

        /// <summary>
        /// Возвращает и задает адрес. Длина должна быть меньше 500 символов.
        /// </summary>
        public string Address
        {
            get => _address;
            set
            {
                ValueValidator.AssertStringOnLength(value, 500, "Address");
                _address = value;
            }
        }

        /// <summary>
        /// Возвращает и задает счетчик товаров.
        /// </summary>
        public static int AllItemsCount
        {
            get => _allItemsCount;
            private set
            {
                _allItemsCount = value;
            }
        }

        /// <summary>
        /// Возвращает уникальный номер товара.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullName">Полное имя в формате Фамилия Имя Отчество. 
        /// Длина должна быть меньше 200 символов. </param>
        /// <param name="address">Адрес. Длина должна быть меньше 500 символов.</param>
        public Customer(string fullName, string address)
        {
            FullName = fullName;
            Address = address;
            AllItemsCount++;
            Id = AllItemsCount;
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Customer"/>.
        /// </summary>
        public Customer()
        {
            AllItemsCount++;
            Id = AllItemsCount;
        }
    }
}
