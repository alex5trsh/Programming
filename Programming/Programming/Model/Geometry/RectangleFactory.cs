using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//TODO:XML-комментарии
namespace Programming.Model.Geometry
{
    public static class RectangleFactory
    {
        public static Rectangle Randomize()
        {
            Random rand = new Random();
            Rectangle newRectangle = new Rectangle();
            newRectangle.Length = Math.Round(1 + rand.NextDouble() * 99);
            newRectangle.Width = Math.Round(1 + rand.NextDouble() * 99);
            int x = rand.Next(1, 300);
            int y = rand.Next(1, 300);
            newRectangle.Center = new Point2D(x, y);

            return newRectangle;
        }
    }
}
