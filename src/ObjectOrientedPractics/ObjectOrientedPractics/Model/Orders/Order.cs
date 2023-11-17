using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Model.Orders
{
    /// <summary>
    /// Хранит данные о заказах.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Счетчик заказов.
        /// </summary>
        private static int _allOrdersCount;

        /// <summary>
        /// Адрес доставки.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Товары.
        /// </summary>
        private List<Item> _items;

       /// <summary>
       /// Общая стоимость.
       /// </summary>
       private double _cost;

        private double _discountAmount;

        private double _total;

        /// <summary>
        /// Возвращает и задает счетчик заказов.
        /// </summary>
        public static int AllOrdersCount
        {
            get => _allOrdersCount;
            private set
            {
                _allOrdersCount = value;
            }
        }

        /// <summary>
        /// Возвращает уникальный номер заказа.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Возвращает дату заказа.
        /// </summary>
        public string Date { get; }

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
        /// Возвращает и задает товары.
        /// </summary>
        public List<Item> Items
        {
            get => _items;
            set
            {
                _items = value;
            }
        }

        /// <summary>
        /// Возвращает и задает общую стоимость. Должна быть идентична <see cref="Cart.Amount"/>.
        /// </summary>
        public double Cost
        {
            get => _cost;
            set
            {
                Cart cart = new Cart(Items);
                if (value == cart.Amount)
                {
                    _cost = value;
                }

            }
        }

        
        /// <summary>
        /// Возвращает и задает состояние заказа.
        /// </summary>
        public OrderStatus OrderStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double DiscountAmount 
        {
            get=>_discountAmount;
            set
            {
                _discountAmount = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double Total 
        { 
            get => _total;
            private set
            {
                _total = Cost-DiscountAmount;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Order"/>.
        /// </summary>
        /// <param name="address">Адрес.</param>
        /// <param name="items">Товары.</param>
        /// <param name="cost">Общая стоимость.</param>
        /// <param name="orderStatus">Состояние заказа.</param>
        public Order(Address address, List<Item> items, double cost, OrderStatus orderStatus/*, double discountAmount*/)
        {
            Address = address;
            Items = items;
            Cost = cost;
            OrderStatus = orderStatus;
            //DiscountAmount = discountAmount;
            AllOrdersCount++;
            Id = AllOrdersCount;
            Date = DateTime.Now.ToLongDateString();       
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Order"/>.
        /// </summary>
        public Order()
        {
            AllOrdersCount++;
            Id = AllOrdersCount;
            Date = DateTime.Now.ToLongDateString();
        }
    }
}
