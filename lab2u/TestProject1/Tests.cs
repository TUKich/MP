using System;
using lab2u;
using NUnit.Framework;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        [TestCase(1, 2, 3, 4)]
        [TestCase(23, 43, 54, 21)]
        public void add(int i1,int i2, int i3, int i4)
        {
            Program p = new Program();
            p.add(i1,i2,i3,i4);
            Boolean b = p.peek() == 21 || p.peek() == 4;
            Assert.True(b);
        }
        [TestCase(1, 2, 3, 4)]
        [TestCase(23, 43, 54, 21)]
        public void Con(int i1,int i2, int i3, int i4)
        {
            Program p = new Program();
            p.add(i1,i2,i3,i4);
            Boolean b = p.con(4);
            Assert.AreEqual(b,p.con(4));
        }
    }
}