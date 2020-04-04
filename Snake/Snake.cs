using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Snake : Figure
    {
        Direction direction;
        public Snake(Point tail, int leght, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();
            
            for (int i = 0; i < leght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList[0];
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();

        }

        private Point GetNextPoint()
        {
            //Console.WriteLine(pList.Capacity-2);
            Point head = pList[pList.Capacity - 2];
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }
    }
}
