using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Figure
    {
        protected List<Point> pList;

        public void Draw(ConsoleColor color = ConsoleColor.White)
        {
            foreach (Point p in pList)
            {
                p.Draw(color);
            }
        }

        internal bool IsHit(Figure figure)
        {
            foreach(var p in pList)
            {
                if (figure.IsHit(p))
                {
                    return true;
                }
            }
            return false;
        }

        internal bool IsHit(Point point)
        {
            foreach (var p in pList)
            {
                if (point.IsHit(p))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
