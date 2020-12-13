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

			Walls walls = new Walls(80, 25);
			walls.Draw();

			// отрисовка Точка
			Point p = new Point(5, 5, '*');
			Snake snake = new Snake(p, 8, Direction.RIGHT);
			snake.Drow();

			FoodCreator foodCreator = new FoodCreator(78, 24, '$');
			Point food = foodCreator.CreateFood();
			food.Draw();

			while(true)
			{
				if (walls.IsHit(snake) || snake.IsHitTail())
                {
					break;
                }

				if (snake.Eat(food))
                {
					food = foodCreator.CreateFood();
					food.Draw();
                } 
				else
                {
					snake.Move();
                }

				Thread.Sleep(150);

				if (Console.KeyAvailable)
				{
					ConsoleKeyInfo key = Console.ReadKey();
					snake.HandleKey(key.Key);
				}
			}
		}
	}
}
