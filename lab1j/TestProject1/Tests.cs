using System;
using ConsoleApp3;
using NUnit.Framework;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Program p = new Program();
            bool a = p.To(3, 2, 2);
            Assert.AreEqual(a, true);
        }

        [Test]
        [TestCase(1, 2, 2, false)]
        [TestCase(3, 2, 2, true)]
        [TestCase(6, -2, -4, true)]
        public void Test2(int R, int x, int y, bool a)
        {
            Program p = new Program();
            bool d = p.To(R, x, y);
            Assert.AreEqual(d,a);
        }
    }
}