using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Model.Orders
{
    /// <summary>
    /// Хранит данные о приоритетных заказах.
    /// </summary>
    class PriorityOrder : Order
    {
        /// <summary>
        /// Желаемая дата доставки.
        /// </summary>
        private DateTime _dateDelivery;

        /// <summary>
        /// Желаемое время доставки.
        /// </summary>
        private string _timeDelivery;

        /// <summary>
        /// Возвращает и задает желаемую дату доставки.
        /// </summary>
        public DateTime DateDelivery
        {
            get => _dateDelivery;
            set
            {
                _dateDelivery = value;
            }

        }

        /// <summary>
        /// Возвращает и задает желаемое время доставки.
        /// </summary>
        public string TimeDelivery
        {
            get => _timeDelivery;
            set
            {
                _timeDelivery = value;
            }

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="PriorityOrder"/>
        /// </summary>
        /// <param name="address">Адрес.</param>
        /// <param name="items">Товары.</param>
        /// <param name="cost">Общая стоимость.</param>
        /// <param name="orderStatus">Состояние заказа.</param>
        /// <param name="discountAmount">Размер примененной скидки.</param>
        /// <param name="dateDelivery">Желаемая дата доставки.</param>
        /// <param name="timeDelivery">Желаемое время доставки.</param>
        public PriorityOrder(Address address, List<Item> items, double cost, OrderStatus orderStatus,
            double discountAmount,DateTime dateDelivery, string timeDelivery) :
            base(address, items, cost, orderStatus , discountAmount)
        {
            DateDelivery = dateDelivery;
            TimeDelivery = timeDelivery;
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="PriorityOrder"/>
        /// </summary>
        public PriorityOrder() : base()
        {

        }

    }
}

