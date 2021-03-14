using System;
using System.Collections.Generic;
using System.Linq;
using Rectangle.Impl;

namespace Rectangle.Console
{
	class Program
	{
		/// <summary>
		/// Use this method for local debugging only. The implementation should remain in Rectangle.Impl project.
		/// See TODO.txt file for task details.
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			List<Point> points = new List<Point>();
			points = Service.generateList(5);

			var rectangle = Service.FindRectangle(points);
			foreach (var item in points)
			{
				System.Console.WriteLine("X: {0}  Y: {1} ", item.X, item.Y);
			}
			System.Console.WriteLine("X: {0}  Y: {1}  Width: {2} Height: {3}", rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);



		}
	}
}
