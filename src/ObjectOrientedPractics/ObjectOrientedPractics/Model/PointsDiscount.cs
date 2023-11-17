using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о скидке накопительных баллов.
    /// </summary>
    class PointsDiscount
    {
        /// <summary>
        /// Баллы.
        /// </summary>
        private int _points=0;

        /// <summary>
        /// Возвращает баллы.
        /// </summary>
        public int Points
        {
            get => _points;
            private set
            {
                ValueValidator.AssertLengthInRange(value, 0, 1000000, "Points");
                _points = value;
            }
        }

        /// <summary>
        /// Возвращает название скидки.
        /// </summary>
        public string Info
        {
            get => $"Накопительная - {Points} баллов";
        }

        /// <summary>
        /// Рассчитывает доступную скидку для списка продуктов.
        /// </summary>
        /// <param name="items">Спиоск товаров.</param>
        /// <returns>Возвращает размер скидки.</returns>
        public double Calculate(List<Item> items)
        {
            double amount = 0;
            for(int i=0;i<items.Count;i++)
            {
                amount += items[i].Cost;
            }

            double amount30 = amount * 0.3;

            if(Points>amount30)
            {
                return Math.Ceiling(amount30);
            }

            return Points;
        }

        /// <summary>
        /// Применяет доступную скидку к товарам.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Возвращает размер скидки.</returns>
        public double Apply(List<Item> items)
        {
            int discount = Convert.ToInt32(Calculate(items));
            Points -= discount;

            return Points;
        }

        /// <summary>
        /// Добавляет новые баллы на основе списка товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        public void Update(List<Item> items)
        {
            double amount = 0;
            for (int i = 0; i < items.Count; i++)
            {
                amount += items[i].Cost;
            }

            int newPoints = Convert.ToInt32(Math.Ceiling(amount * 0.1));
            Points += newPoints;
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="PointsDiscount"/>
        /// </summary>
        public PointsDiscount()
        {

        }
    }
}
