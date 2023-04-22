using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
    public class Rectangle
    {
        private double _length;

        private double _width;

        private static int _allRectanglesCount;

        public double Length
        {
            get => _length;
            set
            {
                Validator.AssertOnPositiveValue(value, "Length");

                _length = value;
            }
            
        }

        public double Width
        {
            get => _width;
            set
            {
                Validator.AssertOnPositiveValue(value, "Width");

                _width = value;
            }
            
        }

        public string Color { get; set; }

        public Point2D Center { get; set; }

        public static int AllRectanglesCount
        {
            get => _allRectanglesCount;
            private set
            {
                _allRectanglesCount = value;
            }

        }
        
        public int Id { get; }

        public Rectangle(double length, double width, string color, Point2D center)
        {
            Length = length;
            Width = width;
            Color = color;
            Center = center;
            AllRectanglesCount++;
            Id = AllRectanglesCount; 
        }
        public Rectangle()
        {
            AllRectanglesCount++;
            Id = AllRectanglesCount; 
        }

        
    }
}
