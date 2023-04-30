using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит координаты.
    /// </summary>
    public class Point2D
    {
        /// <summary>
        /// TODO: грам.ошибка (+)
        /// Координата X.
        /// </summary>
        private int _x;

        /// <summary>
        /// Координата Y.
        /// </summary>
        private int _y;

        /// <summary>
        /// Возвращает и задает координату X. Должна состоять только из положительных чисел.
        /// </summary>
        public int X
        {
            get => _x;
            private set
            {
                Validator.AssertOnPositiveValue(value, "X");

                _x = value;
            }
        }

        /// <summary>
        /// Возвращает и задает координату Y. Должна состоять только из положительных чисел.
        /// </summary>
        public int Y
        {
            get => _y;
            private set
            {
                Validator.AssertOnPositiveValue(value, "Y");

                _y = value;
            }
        }

        /// <summary>
        /// TODO: грам.ошибка (+)
        /// Создает экземпляр класса <see cref="Point2D"/>.
        /// </summary>
        /// <param name="x">Координата X. Должна состоять только из положительных чисел.</param>
        /// <param name="y">Координата Y. Должна состоять только из положительных чисел.</param>
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
