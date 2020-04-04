using System;
using System.Collections.Generic;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Console.BufferHeight.ToString());
            //Console.WriteLine(Console.BufferWidth.ToString());
            //Console.WriteLine(Console.SetWindowSize);
            //Console.WriteLine(Console.LargestWindowWidth);

            Console.SetWindowSize(80, 25);

            // Рамочка
            HorizontalLine upLine = new HorizontalLine(0, 79, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 79, 24, '+');
            VerticalLine leftLine = new VerticalLine(1, 23, 0, '+');
            VerticalLine rightLine = new VerticalLine(1, 23, 79, '+');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();


            Point p1 = new Point(4, 5, '*');
            Snake snake = new Snake(p1, 4, Direction.RIGHT);
            snake.Draw();
            int a = 10;
            while (a-- >0)
            {
                Thread.Sleep(300);
                snake.Move();
            }

            Console.ReadKey();
        }


    }
}
