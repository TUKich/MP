using System;
using l7u;
using NUnit.Framework;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        [TestCase("122","15")]
        [TestCase("12212","112")]
        public void Test1(string c, string ex)
        {
            Program p = new Program();
            Assert.AreEqual(true, ex.Contains(p.threein12(c)));
        }
        [TestCase("-1","null")]
        [TestCase("a","null")]
        public void Test2(string c, string ex)
        {
            Program p = new Program();
            Assert.AreEqual(true, ex.Contains(p.threein12(c)));
        }
        [TestCase("102","B")]
        [TestCase("0","0")]
        public void Test3(string c, string ex)
        {
            Program p = new Program();
            Assert.AreEqual(true, ex.Contains(p.threein12(c)));
        }
        [TestCase("11212","AB")]
        [TestCase("12021","BA")]
        public void Test4(string c, string ex)
        {
            Program p = new Program();
            Assert.AreEqual(true, ex.Contains(p.threein12(c)));
        }
    }
}