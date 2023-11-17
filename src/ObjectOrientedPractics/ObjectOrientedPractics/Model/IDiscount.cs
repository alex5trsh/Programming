using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит методы по работе с классами скидок.
    /// </summary>
    public interface IDiscount
    {
        /// <summary>
        /// Возвращает название скидки.
        /// </summary>
        string Info { get; }

        /// <summary>
        /// Рассчитывает доступную скидку.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Возвращает размер скидки.</returns>
        double Calculate(List<Item> items);

        /// <summary>
        /// Рассчитывает и применяет доступную скидку к товарам.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Возвращает размер скидки</returns>
        double Apply(List<Item> items);

        /// <summary>
        /// Добавляет новые баллы/проценты на основе списка товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        void Update(List<Item> items);
    }
}
