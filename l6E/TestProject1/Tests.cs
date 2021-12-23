using System;
using l6E;
using NUnit.Framework;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        [TestCase("Hello ",6,"World!", "Hello World!")]
        [TestCase("Со",1,"ол", "Соло")]
        public void Test1(string s , int i , string p, string ex)
        {
            Program pr = new Program();
            Assert.AreEqual(true,ex.Contains(pr.Put(s,i,p)));
        }
    }
}