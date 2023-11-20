using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Хранит данные о скидке накопительных баллов.
    /// </summary>
    public class PointsDiscount: IDiscount,IComparable
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

        public string Info
        {
            get => $"Накопительная - {Points} баллов";
        }

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

        public double Apply(List<Item> items)
        {
            int discount = Convert.ToInt32(Calculate(items));
            Points -= discount;

            return Points;
        }

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

        /// <inheritdoc />
        public int CompareTo(object other)
        {
            if (other == null)
                return 1;

            if (other is PointsDiscount == false)
                throw new ArgumentException("Object is not a PointsDiscount");

            var otherPointsDiscount = (PointsDiscount)other;
            return this.Points.CompareTo(otherPointsDiscount.Points);

        }
    }
}
