using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeigth)
        {
            wallList = new List<Figure>();

            // Отрисовка рамки
            HorizontalLine lineUp = new HorizontalLine(0, mapWidth - 2, 0, sym: '█');
            HorizontalLine lineDown = new HorizontalLine(0, mapWidth - 2, mapHeigth -1, sym: '█');
            VerticalLine leftLine = new VerticalLine(0, mapHeigth - 1, 0, sym: '█');
            VerticalLine rightLine = new VerticalLine(0, mapHeigth - 1, mapWidth - 2, sym: '█');

            wallList.Add(lineUp);
            wallList.Add(lineDown);
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

        internal void Draw()
        {
            foreach(Figure f in wallList)
            {
                f.Drow();
            }
        }
    }
}
