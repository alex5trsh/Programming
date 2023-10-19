﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;


namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о товарах.
    /// </summary>
    public class Item
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
    }
}
