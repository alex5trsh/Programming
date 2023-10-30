using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о покупателях.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Счетчик товаров.
        /// </summary>
        private static int _allItemsCount;

        /// <summary>
        /// Полное имя.
        /// </summary>
        private string _fullName;

        /// <summary>
        /// Адрес.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Корзина.
        /// </summary>
        private Cart _cart;

        /// <summary>
        /// Возвращает и задает полное имя в формате Фамилия Имя Отчество. 
        /// Длина должна быть меньше 200 символов. 
        /// </summary>
        public string FullName
        {
            get => _fullName;
            set
            {
                ValueValidator.AssertStringOnFullName(value, "FullName");
                ValueValidator.AssertStringOnLength(value, 1, 200, "FullName");
                _fullName = value;
            }
        }

        /// <summary>
        /// Возвращает и задает адрес.
        /// </summary>
        public Address Address
        {
            get => _address;
            set
            {
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

        public Cart Cart
        {
            get => _cart;
            set
            {
                _cart = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullName">Полное имя в формате Фамилия Имя Отчество. 
        /// Длина должна быть меньше 200 символов. </param>
        public Customer(string fullName)
        {
            FullName = fullName;
            Address =new Address(100000, "Country","City","Street","Building","Apartment") ;
            AllItemsCount++;
            Id = AllItemsCount;
            Cart = new Cart();
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Customer"/>.
        /// </summary>
        public Customer()
        {
            AllItemsCount++;
            Id = AllItemsCount;
            //Cart = new Cart();
        }

    }
}
