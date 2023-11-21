using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.Model.Enums;


namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о товарах.
    /// </summary>
    public class Item : ICloneable,IEquatable<Item>,IComparable
    {
        /// <summary>
        /// Счетчик товаров.
        /// </summary>
        private static int _allItemsCount;

        /// <summary>
        /// Название.
        /// </summary>
        private string _name;

        /// <summary>
        /// Описание.
        /// </summary>
        private string _info;

        /// <summary>
        /// Стоимость.
        /// </summary>
        private double _cost;

        /// <summary>
        /// Возвращает и задает название. Длина должна быть меньше 200.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                ValueValidator.AssertStringOnLength(value, 1, 200, "Name");

                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задает описание. Длина должна быть меньше 1000.
        /// </summary>
        public string Info
        {
            get => _info;
            set
            {
                ValueValidator.AssertStringOnLength(value, 1, 1000, "Info");

                _info = value;
            }
        }

        /// <summary>
        /// Возвращает и задает стоимость. Должна состоять из чисел от 0 до 100 000.
        /// </summary>
        public double Cost
        {
            get => _cost;
            set
            {
                ValueValidator.AssertValueInRange(value, 0, 100000, "Cost");

                _cost = value;
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
        /// Возвращает и задает категорию товара.
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="name">Название. Длина должна быть меньше 200.</param>
        /// <param name="info">Описание. Длина должна быть меньше 1000.</param>
        /// <param name="cost">Стоимость. Должна состоять из чисел от 0 до 100 000.</param>
        /// <param name="category">Категория.</param>
        public Item(string name, string info, double cost, Category category)
        {
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
            AllItemsCount++;
            Id = AllItemsCount;
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Item"/>.
        /// </summary>
        public Item()
        {
            AllItemsCount++;
            Id = AllItemsCount;
        }

        /// <inheritdoc />
        /// <remarks>В копии экземпляра будет новый Id.</remarks>
        public object Clone() 
        { 
            return new Item(this.Name, this.Info, this.Cost, this.Category);
        }

        /// <inheritdoc />
        public override bool Equals(object other)
        {
            if (other == null)
                return false;

            if (other is Item == false)
                return false;

            if (object.ReferenceEquals(this, other))
                return true;

            var otherItem = (Item)other;
            return (this.Name == otherItem.Name && this.Category == otherItem.Category && this.Id == otherItem.Id);
        }

        /// <inheritdoc />
        public bool Equals(Item otherItem)
        {
            if (otherItem == null)
                return false;

            if (object.ReferenceEquals(this, otherItem))
                return true;

            return (this.Name == otherItem.Name && this.Category == otherItem.Category&&this.Id==otherItem.Id);
        }

        /// <inheritdoc/>
        public int CompareTo(object other)
        {
            if (other == null) 
                return 1;

            if (other is Item == false)
                throw new ArgumentException("Object is not a Item");

            var otherItem = (Item)other;
            return this.Cost.CompareTo(otherItem.Cost);

        }
    }
}
