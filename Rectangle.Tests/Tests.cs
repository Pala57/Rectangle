using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Rectangle.Impl;
using Assert = NUnit.Framework.Assert;

namespace Rectangle.Tests
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void Test1()
		{
			List<Point> points = new List<Point>();
			points = Service.generateList(2);
			var rectangle = Service.FindRectangle(points);
			Assert.IsNotNull(rectangle);
		}
		[Test]
		[TestMethod]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void Test2()
		{
			List<Point> points = new List<Point>();
			points = Service.generateList(1);
			var exception = Assert.Throws<ArgumentOutOfRangeException>(() => Service.FindRectangle(points));
			Assert.AreEqual(null, null);

		}
	}
}