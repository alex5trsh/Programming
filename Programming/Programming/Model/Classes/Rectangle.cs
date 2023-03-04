using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    class Rectangle
    {
        private double Length
        {
            set
            {
                if (value < 0)
                { }
                else
                { 
                    Length = value; 
                }
            }
            get { return Length; }
        }
        private double Width
        {
            set
            {
                if (value < 0)
                { }
                else
                {
                    Width = value;
                }
            }
            get { return Width; }
        }
        private string Color { get; set; }
    }
}
