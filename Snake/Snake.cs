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
            head.Draw(ConsoleColor.Green);
        }

        private Point GetNextPoint()
        {
            //Console.WriteLine(pList.Capacity-2);
            Point head = pList[pList.Count - 1];
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        internal bool IsHitTail()
        {
            var head = pList[pList.Count - 1];
            for (int i = 0; i < pList.Count-2; i++)
            {
                if (head.IsHit(pList[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
            {
                direction = Direction.LEFT;
            }
            else if (key == ConsoleKey.RightArrow)
            {
                direction = Direction.RIGHT;
            }
            else if (key == ConsoleKey.DownArrow)
            {
                direction = Direction.DOWN;
            }
            else if (key == ConsoleKey.UpArrow)
            {
                direction = Direction.UP;
            }
        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                food.Draw(ConsoleColor.Green);
                pList.Add(food);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
