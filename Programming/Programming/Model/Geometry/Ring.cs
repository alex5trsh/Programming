using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит данные о кольцах.
    /// </summary>
    class Ring
    {
        /// <summary>
        /// Внутренний радиус.
        /// </summary>
        private double _innerRadius; 

        /// <summary>
        /// Внешний радиус.
        /// </summary>
        private double _outerRadius;

        /// <summary>
        /// Возвращает и задает центр.
        /// </summary>
        public Point2D CenterOfRing { get; set; }

        /// <summary>
        /// Возвращает и задает внутренний радиус. Должен состоять только из чисел, которые меньше чем внешний радиус.
        /// </summary>
        public double InnerRadius  
        {
            get => _innerRadius;
            set
            {
                Validator.AssertValueInRange(value, 1, OuterRadius, "InnerRadius");

                _innerRadius = value;
            }
        }

        /// <summary>
        /// Возвращает и задает внешний радиус. Должен состоять только из чисел, которые больше чем внутренний радиус.
        /// </summary>
        public double OuterRadius 
        {
            get => _outerRadius;
            set
            {
                Validator.AssertValueInRange(value, InnerRadius, double.MaxValue, "OuterRadius" );

                _outerRadius = value;
            }
        }

        /// <summary>
        /// Вычисляет площадь.
        /// </summary>
        /// <param name="ring">Имя необходимого объекта.</param>
        /// <returns>Возвращает площадь.</returns>
        private double Area(Ring ring)
        { 
            return Math.PI * (ring.OuterRadius * ring.OuterRadius
                - ring.InnerRadius * ring.InnerRadius);
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Ring"/>.
        /// </summary>
        /// <param name="centerOfRing">Центр.</param>
        /// <param name="innerRadius">Внутренний радиус. Должен состоять только из чисел, 
        /// которые меньше чем внешний радиус.</param>
        /// <param name="outerRadius">Внешний радиус. Должен состоять только из чисел, 
        /// которые больше чем внутренний радиус.</param>
        public Ring(Point2D centerOfRing, int innerRadius, int outerRadius)
        {
            CenterOfRing = centerOfRing;
            InnerRadius = innerRadius;
            OuterRadius = outerRadius;
        }
    }
}
