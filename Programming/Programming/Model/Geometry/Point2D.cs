using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//TODO:XML-комментарии
namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит данные о точках.
    /// </summary>
    public class Point2D
    {
        /// <summary>
        /// 
        /// </summary>
        private int _x;

        /// <summary>
        /// 
        /// </summary>
        private int _y;

        /// <summary>
        /// 
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
        /// 
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
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
