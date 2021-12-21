using System;
using lab6;
using NUnit.Framework;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        [TestCase("Привет ",7,"Мир", "Привет Мир")]
        [TestCase("Дбро",1,"о", "Добро")]
        public void Test1(string s , int i , string p, string ex)
        {
            Program pr = new Program();
            
            Assert.AreEqual(true,ex.Contains(pr.Put(s,i,p)));
        }
    }
}