using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о корзине.
    /// </summary>
    public class Cart
    {
        /// <summary>
        /// Товары.
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Стоимость.
        /// </summary>
        private double _amount;

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
        /// Возвращает стоимость.
        /// </summary>
        public double Amount
        {
            get
            {
                if (Items.Count == 0 || Items.Count==null)
                {
                    return 0.0;
                }
                else
                {
                    for (int i = 0; i < Items.Count; i++)
                    {
                        _amount += Items[i].Cost;
                    }
                    return _amount;
                }
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Cart"/>.
        /// </summary>
        /// <param name="items">Товары.</param>
        public Cart(List<Item> items)
        {
            Items = items;
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Cart"/>.
        /// </summary>
        public Cart()
        {

        }

    }
}
