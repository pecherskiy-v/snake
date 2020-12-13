using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snake
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.SetBufferSize(120, 30);

			// Отрисовка рамки
			HorizontalLine lineUp = new HorizontalLine(xleft: 0, xReight: 78, y: 0, sym: '█');
			HorizontalLine lineDown = new HorizontalLine(xleft: 0, xReight: 78, y: 24, sym: '█');
			VerticalLine leftLine = new VerticalLine(0, 24, 0, sym: '█');
			VerticalLine rightLine = new VerticalLine(0, 24, 78, sym: '█');

			lineUp.Drow();
			lineDown.Drow();
			leftLine.Drow();
			rightLine.Drow();

			// отрисовка Точка
			Point p = new Point(5, 5, '*');
			Snake snake = new Snake(p, 8, Direction.RIGHT);
			snake.Drow();

			FoodCreator foodCreator = new FoodCreator(78, 24, '$');
			Point food = foodCreator.CreateFood();
			food.Draw();

			while(true)
			{
				if (snake.Eat(food))
                {
					food = foodCreator.CreateFood();
					food.Draw();
                } 
				else
                {
					snake.Move();
                }

				Thread.Sleep(300);

				if (Console.KeyAvailable)
				{
					ConsoleKeyInfo key = Console.ReadKey();
					snake.HandleKey(key.Key);
				}
			}
		}
	}
}
