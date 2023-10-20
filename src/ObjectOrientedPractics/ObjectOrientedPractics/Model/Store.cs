using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные об товарах и покупателях.
    /// </summary>
    public class Store
    {
        /// <summary>
        /// Товары.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Покупатели.
        /// </summary>
        private List<Customer> _customers;

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
        /// Возвращает и задает покупателей.
        /// </summary>
        public List<Customer> Customers
        { 
            get => _customers; 
            set 
            { 
                _customers = value; 
            }
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Store"/>.
        /// </summary>
        public Store()
        {
            Items = new List<Item>();
            Customers = new List<Customer>();

        }
    }
}
