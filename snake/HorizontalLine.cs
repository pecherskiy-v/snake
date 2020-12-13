using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
	class HorizontalLine : AbstractLine
	{
		public HorizontalLine(int xleft, int xReight, int y, char sym)
		{
			pList = new List<Point>();
			for (int x = xleft; x <= xReight; x++)
			{
				Point p = new Point(x,y,sym);
				pList.Add(p);
			}
		}
	}
}
