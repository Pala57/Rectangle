using System;
using System.Collections.Generic;
using System.Linq;

namespace Rectangle.Impl
{
	public static class Service
	{
		/// <summary>
		/// See TODO.txt file for task details.
		/// Do not change contracts: input and output arguments, method name and access modifiers
		/// </summary>
		/// <param name="points"></param>
		/// <returns></returns>
		public static Rectangle FindRectangle(List<Point> points)
		{
         
			points.GroupBy(v => v).Where(g => g.Count() > 1).Select(g => g.Key); 

			foreach (var item in points)
            {
                if (item.Equals(null))
                {
					throw new NotImplementedException();
				}
               
            }
		
			if (points.Count < 2)
            {
				throw new ArgumentOutOfRangeException();
			}
          
	
				var x_query = from Point p in points select p.X;
				int xmin = x_query.Min()+1;
				int xmax = x_query.Max();

				var y_query = from Point p in points select p.Y;
				int ymin = y_query.Min();
				int ymax = y_query.Max();

				return new Rectangle(xmin, ymin, xmax - xmin, ymax - ymin);
			}

		public static List<Point> generateList(int count)
		{

			List<Point> points = new List<Point>();
			Random rnd = new Random();
			points.GroupBy(v => v).Where(g => g.Count() > 1).Select(g => g.Key);
			for (int i = 0; i < count; i++)
			{
				Point p = new Point();
				p.X = (rnd.Next(0, 100));
				p.Y = (rnd.Next(0, 100));
				points.Add(p);
			}


			return points;

		}


		//	throw new NotImplementedException();
	}
	}

