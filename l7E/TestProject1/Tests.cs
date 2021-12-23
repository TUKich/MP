using System;
using l7E;
using NUnit.Framework;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        [TestCase("10","3")]
        [TestCase("111","13")]
        public void Test1(string c, string ex)
        {
            Program p = new Program();
            Assert.AreEqual(true, ex.Contains(p.ThreeTen(c)));
        }
        [TestCase("-1","null")]
        [TestCase("a","null")]
        public void Test2(string c, string ex)
        {
            Program p = new Program();
            Assert.AreEqual(true, ex.Contains(p.ThreeTen(c)));
        }
        [TestCase("101","10")]
        [TestCase("0","0")]
        public void Test3(string c, string ex)
        {
            Program p = new Program();
            Assert.AreEqual(true, ex.Contains(p.ThreeTen(c)));
        }
        [TestCase("11120","123")]
        [TestCase("1101000","999")]
        public void Test4(string c, string ex)
        {
            Program p = new Program();
            Assert.AreEqual(true, ex.Contains(p.ThreeTen(c)));
        }
    }
}