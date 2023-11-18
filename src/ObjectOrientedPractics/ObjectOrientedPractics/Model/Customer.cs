using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model.Orders;

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
        /// Заказы.
        /// </summary>
        private BindingList<Order> _order;

        /// <summary>
        /// Приоритетность.
        /// </summary>
        private bool _isPriority;

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

        /// <summary>
        /// Возвращает и задает корзину.
        /// </summary>
        public Cart Cart
        {
            get => _cart;
            set
            {
                _cart = value;
            }
        }

        /// <summary>
        /// Возвращает и задает заказы.
        /// </summary>
        public BindingList<Order> Order
        {
            get => _order;
            set
            {
                _order = value;
            }
        }

        /// <summary>
        /// Возвращает и задает приоритетность.
        /// </summary>
        public bool IsPriority
        {
            get => _isPriority;
            set
            {
                _isPriority = value;
            }
        }

        /// <summary>
        /// Возвращает и задает скидки.
        /// </summary>
        public List<IDiscount> Discounts { get; set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullName">Полное имя в формате Фамилия Имя Отчество.</param>
        /// <param name="orders">Заказы.</param>
        public Customer(string fullName, BindingList<Order> orders)
        {
            FullName = fullName;
            Address =new Address(100000, "Country","City","Street","Building","Apartment");
            IsPriority = false;
            AllItemsCount++;
            Id = AllItemsCount;
            Cart = new Cart(new List<Item>());
            Order =orders;
            Discounts = new List<IDiscount>() { new PointsDiscount() };
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Customer"/>.
        /// </summary>
        public Customer()
        {
            AllItemsCount++;
            Id = AllItemsCount;
            Discounts = new List<IDiscount>() { new PointsDiscount() };
        }

    }
}
