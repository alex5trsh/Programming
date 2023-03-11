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

        private double Length
        {
            get => _length;
            set
            {
                if (value < 0.0)
                {
                    throw new ArgumentException();
                }
                _length = value;
            }
            
        }

        private double _width;

        private double Width
        {
            get => _width;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                _width = value;
            }
            
        }

        private string Color { get; set; }

        public Rectangle(double length, int width, string color)
        {
            Length = length;
            Width = width;
            Color = color;
        }
    }
}
