using System;
using lab7;
using NUnit.Framework;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        [TestCase("12","5")]
        [TestCase("1212","32")]
        public void Test1(string c, string ex)
        {
            Program p = new Program();
            Assert.AreEqual(true, ex.Contains(p.threein16(c)));
        }
        [TestCase("-1","null")]
        [TestCase("a","null")]
        public void Test2(string c, string ex)
        {
            Program p = new Program();
            Assert.AreEqual(true, ex.Contains(p.threein16(c)));
        }
        [TestCase("120","F")]
        [TestCase("0","0")]
        public void Test3(string c, string ex)
        {
            Program p = new Program();
            Assert.AreEqual(true, ex.Contains(p.threein16(c)));
        }
        [TestCase("210012000221220","ABCDEF")]
        [TestCase("1011102120201200","FEDCBA")]
        public void Test4(string c, string ex)
        {
            Program p = new Program();
            Assert.AreEqual(true, ex.Contains(p.threein16(c)));
        }
    }
}