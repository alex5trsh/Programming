using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
    class RectangleFactory
    {
        public Rectangle Randomize()
        {
            Random run = new Random();
            Rectangle newRectangle = new Rectangle();
            newRectangle.Length = Math.Round(1 + run.NextDouble() * 99);
            newRectangle.Width = Math.Round(1 + run.NextDouble() * 99);
            int x = run.Next(1, 300);
            int y = run.Next(1, 300);
            newRectangle.Center = new Point2D(x, y);

            return newRectangle;
        }
    }
}
