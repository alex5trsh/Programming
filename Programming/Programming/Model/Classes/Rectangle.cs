using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    class Rectangle
    {
        private double _length;

        private double _width;

        public double Length
        {
            get => _length;
            set
            {
                if (value < 0.0)
                {
                    throw new ArgumentException("Длина не может быть отрицательной");
				}
				// TODO: RSDN
				_length = value;
            }
            
        }

        public double Width
        {
            get => _width;
            set
            {
                if (value < 0.0)
                {
                    throw new ArgumentException("Ширина не может быть отрицательной");
				}
				// TODO: RSDN
				_width = value;
            }
            
        }

        public string Color { get; set; }

        public Rectangle(double length, double width, string color)
        {
            Length = length;
            Width = width;
            Color = color;
        }
        public Rectangle()
        {
            
        }
    }
}
