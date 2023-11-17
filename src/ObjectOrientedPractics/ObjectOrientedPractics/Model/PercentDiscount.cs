using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о процентной скидке.
    /// </summary>
    class PercentDiscount
    {
        /// <summary>
        /// Текущий процент.
        /// </summary>
        private int _currentPercent=1;

        /// <summary>
        /// Сумма покупок за все время.
        /// </summary>
        private double _purchaseAmount=0;

        /// <summary>
        /// Возвращает текущий процент
        /// </summary>
        public int CurrentPercent
        {
            get => _currentPercent;
            private set
            {
                _currentPercent = value;
            }
        }

        /// <summary>
        /// Возвращает и задает категорию.
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Возвращает сумму за все время.
        /// </summary>
        public double PurchaseAmount
        {
            get => _purchaseAmount;
            private set
            {
                _purchaseAmount = value;
            }
        }

        /// <summary>
        /// Возвращает название скидки.
        /// </summary>
        public string Info
        {
            get => $"Процентная {Category} - {CurrentPercent}%";
        }

        /// <summary>
        /// Рассчитывает доступную скидку для списка продуктов.
        /// </summary>
        /// <param name="items">Спиоск товаров.</param>
        /// <returns>Возвращает размер скидки.</returns>
        public double Calculate(List<Item> items)
        {
            double amount = 0;
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Category == Category)
                {
                    amount += items[i].Cost;
                }
            }

            if (amount == 0)
            {
                return 0;
            }
            double percent = Convert.ToDouble(CurrentPercent) / 100;
            double discount = amount *percent ;
            return discount;
        }

        /// <summary>
        /// Применяет доступную скидку к товарам.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Возвращает размер скидки.</returns>
        public double Apply(List<Item> items)
        {
            double amount = 0;
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Category == Category)
                {
                    amount += items[i].Cost;
                }
            }

            if (amount == 0)
            {
                return 0;
            }
            double discount = amount * CurrentPercent;

            return discount;
        }

        /// <summary>
        /// Добавляет новые проценты на основе списка товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        public void Update(List<Item> items)
        {
            double amount = 0;
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Category == Category)
                {
                    amount += items[i].Cost;
                }
            }
            PurchaseAmount += amount;

            while (amount - 1000 > 0)
            {
                if (CurrentPercent < 10)
                {
                    CurrentPercent++;
                    amount -= 1000;
                }
                else
                {
                    break;
                }
            }

        }

        /// <summary>
        /// Создает экземпляр товара <see cref="PercentDiscount"/>.
        /// </summary>
        /// <param name="category"></param>
        public PercentDiscount(Category category)
        {
            Category = category;
        }
    }
}
