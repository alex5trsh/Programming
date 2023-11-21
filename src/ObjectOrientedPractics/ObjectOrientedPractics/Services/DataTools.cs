using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Хранит методы фильтрации объектов.
    /// </summary>
    class DataTools
    {
        /// <summary>
        /// Сравнивает стоимость проверяемого объекта с определенной стоимостью.
        /// </summary>
        /// <param name="item">Проверяемый объект.</param>
        /// <param name="cost">Стоимость, с которой происходит сравнение.</param>
        /// <returns>Возвращает true, если стоимость проверяемого объекта больше введенной стоимости.
        /// Возвращает false, если стоимость проверяемого объекта меньше введенной стоимости.</returns>
        public static bool CompareCost(Item item, object cost) 
        { 
            return item.Cost > Convert.ToDouble(cost); 
        }

        /// <summary>
        /// Сравнивает категорию проверяемого объекта с определенной категорией.
        /// </summary>
        /// <param name="item">Проверяемый объект.</param>
        /// <param name="category">Категория, с которой происходит сравнение.</param>
        /// <returns>Возвращает true, если категория проверяемого объекта равна введенной категории.
        /// Возвращает false, если  категория проверяемого объекта не равна введенной категории.</returns>
        public static bool CompareCategory(Item item, object category) 
        { 
            return item.Category==(Category)category; 
        }

        /// <summary>
        /// Сортирует список объектов по названию в алфавитном порядке.
        /// </summary>
        /// <param name="items">Список объектов.</param>
        /// <returns>Отсортированный список объектов.</returns>
        public static List<Item> SortByName(List<Item> items)
        {
            items.Sort((first, second) => first.Name.CompareTo(second.Name));

            return items ;
        }

        /// <summary>
        /// Сортирует список объектов по стоимости в порядке возрастания.
        /// </summary>
        /// <param name="items">Список объектов.</param>
        /// <returns>Отсоритрованный список объектов по стоимости в порядке возрастания.</returns>
        public static List<Item> SortByAscendingCost(List<Item> items)
        {
            for(int i=0;i<items.Count;i++)
            {
                for(int j=i+1; j<items.Count;j++)
                {
                    if(items[i].Cost>items[j].Cost)
                    {
                        Item temp = items[i];
                        items[i] = items[j];
                        items[j] = temp;
                    }
                }
            }

            return items;
        }

        /// <summary>
        /// Сортирует список объектов по стоимости в порядке убывания.
        /// </summary>
        /// <param name="items">Список объектов.</param>
        /// <returns>Отсоритрованный список объектов по стоимости в порядке убывания.</returns>
        public static List<Item> SortByDecreasingCost(List<Item> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                for (int j = i+1; j < items.Count; j++)
                {
                    if (items[i].Cost < items[j].Cost)
                    {
                        Item temp = items[i];
                        items[i] = items[j];
                        items[j] = temp;
                    }
                }
            }

            return items;
        }

        /// <summary>
        /// Фильтрует объекты по определенному критерию и добавляет их в новый список. 
        /// </summary>
        /// <param name="items">Список объектов.</param>
        /// <param name="compare">Метод, с помощью которого происходит фильтрация по критерию.</param>
        /// <param name="_object">Критерий.</param>
        /// <returns>Новый список с объектами, которые подошли по критерию.</returns>
        public static List<Item> FilterItems(List<Item> items, Func<Item, object, bool> compare, object _object)
        {
            List<Item > newItems = new List<Item>();
            for(int i=0;i<items.Count;i++)
            {
                if(compare(items[i], _object))
                {
                    newItems.Add(items[i]);
                }
            }

            return newItems;
        }

        /// <summary>
        /// Сортирует объекты по определенному критерию
        /// </summary>
        /// <param name="items">Список объектов.</param>
        /// <param name="compare">Метод, с помощью которого происходит сортировка.</param>
        /// <returns>Отсортированный список по определенному критерию.</returns>
        public static List<Item> SortItems(List<Item> items, Func<List<Item>, List<Item>> compare)
        {
            return compare(items);
        }
    }
}
