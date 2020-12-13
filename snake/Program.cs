using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
	class Program
	{
		static void Main(string[] args)
		{
			Point p1 = new Point(1, 3, '*');
			p1.Draw();

			Point p2 = new Point(4, 5, '#');
			p2.Draw();

			HorizontalLine lineH = new HorizontalLine(xleft: 1, xReight: 15, y: 8, sym: '_');
			VerticalLine lineV = new VerticalLine(1, 15, 1, sym: '|');

			lineH.Drow();
			lineV.Drow();

			Console.ReadLine();
		}
	}
}
