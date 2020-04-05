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
            //Console.SetBufferSize(80, 25);
            Console.SetWindowSize(80, 25);
            Console.CursorVisible = false;

            Walls walls = new Walls(80, 25);
            walls.Draw();

            // отрисовка точек
            Point p1 = new Point(4, 5, '*');
            Snake snake = new Snake(p1, 4, Direction.RIGHT);
            snake.Draw(ConsoleColor.Green);

            FoodCreator foodCreator = new FoodCreator(80, 25, '@');
            Point food = foodCreator.CreateFood();
            food.Draw(ConsoleColor.Yellow);

            while (true)
            {
                if (walls.IsHit(snake)||snake.IsHitTail())
                {
                    break;
                }

                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw(ConsoleColor.Yellow);
                }
                else
                {
                    snake.Move();
                }

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);

                }
                Thread.Sleep(100);
                //snake.Move();
            }

            Console.SetCursorPosition(35, 12);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Game over!");
            Console.ReadKey();
        }


    }
}

