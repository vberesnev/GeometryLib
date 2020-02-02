using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometryLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void GetAreaTest()
        {
            int a = 10;
            int b = 10;
            int c = 10;

            int d = 9;
            int e = 12;
            int f = 15;

            Triangle triangle1 = new Triangle(a, b, c);
            Triangle triangle2 = new Triangle(d, e, f);

            var result1 = triangle1.GetArea();
            var result2 = triangle2.GetArea();

            Assert.AreEqual(43.3013, Math.Round(result1, 4));
            Assert.AreEqual(54, result2);

        }
    }
}