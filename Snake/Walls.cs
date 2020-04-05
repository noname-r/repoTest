using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();

            // Рамочка
            HorizontalLine upLine = new HorizontalLine(0, mapWidth-1, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, mapWidth - 1, mapHeight - 2, '+');
            VerticalLine leftLine = new VerticalLine(1, mapHeight-2, 0, '+');
            VerticalLine rightLine = new VerticalLine(1, mapHeight - 2, mapWidth - 1, '+');

            wallList.Add(upLine);
            wallList.Add(downLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
        }

        internal bool IsHit(Figure figure)
        {
            foreach(var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();
            }
        }
    }
}
