using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
   /// <summary>
   /// Хранит данные о прямоугольниках.
   /// </summary>
   public class Rectangle
    {
        /// <summary>
        /// Длина.
        /// </summary>
        private double _length;

        /// <summary>
        /// Ширина.
        /// </summary>
        private double _width;

        /// <summary>
        /// Счетчик прямоугольников.
        /// </summary>
        private static int _allRectanglesCount;

        /// <summary>
        /// Возвращает и задает длину. Должна состоять только из положительных чисел.
        /// </summary>
        public double Length
        {
            get => _length;
            set
            {
                Validator.AssertOnPositiveValue(value, "Length");

                _length = value;
            }    
        }

        /// <summary>
        ///  Возвращает и задает ширину. Должна состоять только из положительных чисел.
        /// </summary>
        public double Width
        {
            get => _width;
            set
            {
                Validator.AssertOnPositiveValue(value, "Width");

                _width = value;
            } 
        }

        /// <summary>
        ///  Возвращает и задает цвет.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        ///  Возвращает и задает центр.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        ///  Возвращает и задает счетчик.
        /// </summary>
        public static int AllRectanglesCount
        {
            get => _allRectanglesCount;
            private set
            {
                _allRectanglesCount = value;
            }

        }

        /// <summary>
        ///  Возвращает идентификатор.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Создает экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="length">Длина. Должна состоять только из положительных чисел.</param>
        /// <param name="width">Ширина. Должна состоять только из положительных чисел.</param>
        /// <param name="color">Цвет.</param>
        /// <param name="center">Центр.</param>
        public Rectangle(double length, double width, string color, Point2D center)
        {
            Length = length;
            Width = width;
            Color = color;
            Center = center;
            AllRectanglesCount++;
            Id = AllRectanglesCount; 
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        public Rectangle()
        {
            AllRectanglesCount++;
            Id = AllRectanglesCount; 
        }  
    }
}
