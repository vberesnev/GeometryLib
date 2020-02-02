using GeometryLib;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometryLib.Tests
{
    [TestClass()]
    public class CircleTests
    {
        [TestMethod()]
        public void GetAreaTest()
        {
            int radius = 10;
            
            Circle circle = new Circle(radius);
            double result = circle.GetArea();
            
            Assert.AreEqual(Math.PI * radius * radius, result);
        }
    }
}

