using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит методы по проверке на пересечение.
    /// </summary>
    class CollisionManager
    {
        /// <summary>
        /// Проверяет, что прямоугольники пересекаются.
        /// </summary>
        /// <param name="rectangle1">Первый проверяемый прямоугольник.</param>
        /// <param name="rectangle2">Второй проверяемый прямоугольник.</param>
        /// <returns>Возвращает true, если прямоугольники пересекаются. И false, если не пересекаются.</returns>
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            double sumWidth = (rectangle1.Width + rectangle2.Width) / 2;
            double sumLength = (rectangle1.Length + rectangle2.Length) / 2;
            int dx = Math.Abs(rectangle1.Center.X - rectangle2.Center.X);
            int dy = Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y);

            return dx < sumWidth && dy < sumLength;
        }

        /// <summary>
        /// Проверяет, что кольца пересекаются.
        /// </summary>
        /// <param name="ring1">Первое проверяемое кольцо.</param>
        /// <param name="ring2">Второе проверяемое кольцо.</param>
        /// <returns>Возвращает true, если кольца пересекаются. И false, если кольца не пересекаются.</returns>
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            double sumRadius = ring1.OuterRadius + ring2.OuterRadius;
            int dx =Math.Abs(ring1.CenterOfRing.X- ring2.CenterOfRing.X);
            int dy = Math.Abs(ring1.CenterOfRing.Y - ring2.CenterOfRing.Y);
            double C = Math.Sqrt(dx * dx + dy * dy);

            return C < sumRadius;
        }
    }
}
