using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MIndBox;

namespace UnitTestForCalcSquare
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSquareTriangle()
        {
            var triangle = new Triangle(3,4,5);
            double actual = triangle.Square();
            double expected = 6;
            Assert.AreEqual(expected,actual);
        }
        [TestMethod]
        public void TestRectTriangle()
        {
            var triangle = new Triangle(3,4,5);
            bool expected = true;
            bool actual = triangle.IsRectTriangle();
            Assert.AreEqual(expected,actual);
        }
        [TestMethod]
        public void TestRectTriangleFalse()
        {
            var triangle = new Triangle(2, 4, 5);
            bool expected = false;
            bool actual = triangle.IsRectTriangle();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestSquareCircle()
        {
            var circle = new Circle(5);
            var expected = Math.Pow(5,2) * Math.PI;
            var actual = circle.Square();
            Assert.AreEqual(expected,actual);
        }
    }
}
