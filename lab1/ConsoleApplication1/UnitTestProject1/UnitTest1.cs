using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Line l1 = new Line();
            Line l2 = new Line();
            l1.a = new Point(1, 1);
            l1.b = new Point(2, 2);
            l2.a = new Point(1, 2);
            l2.b = new Point(2, 1);
            Point p = new Point(1.5, 1.5);
            CalcOfPoint w = new CalcOfPoint();
            Assert.AreEqual(w.Back(l1, l2), p);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Point p1 = new Point(1, 1);
            Point p2 = new Point(1, 1);
            Assert.AreEqual(p1.Equals(p2), true);
        }
        [TestMethod]
        public void TestMethod3()
        {
            Line l1 = new Line();
            Line l2 = new Line();
            l1.a = new Point(1, 1);
            l1.b = new Point(1, 1);
            l2.a = new Point(1, 1);
            l2.b = new Point(1, 1);
            Assert.AreEqual(l1.Equals(l2), false);
        }
      
    }
}

