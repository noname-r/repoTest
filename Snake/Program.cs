using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,3,'*');
            //p1.x = 1;
            //p1.y = 3;
            //p1.sym = '*';
            p1.Draw();

            Console.ReadKey();
        }


    }
}
