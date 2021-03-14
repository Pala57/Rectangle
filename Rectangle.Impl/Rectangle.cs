using System;

namespace Rectangle.Impl
{
	public sealed class Rectangle
	{
		public int X { get; set; }
		public int Y { get; set; }
		public int Width { get; set; }
		public int Height { get; set; }
		public Rectangle()
        {

        }
		public Rectangle(int a,int b,int c,int d)
		{
			X = a;
			Y = b;
			Width = c;
			Height = d;
		}
	}
}
