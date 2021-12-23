using System;
using l4E;
using NUnit.Framework;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        [TestCase("User1", "1234", "User2", "89123", "User3", "ueuwq", true)]
        [TestCase("A", "ert", "V", "sdfg1", "Z", "vbndfg", true)]
        public void Test1(string key1, string pas1, string key2, string pas2, string key3, string pas3, bool e)
        {
            Program h = new Program();
            h.Dobav(key1,pas1);
            h.Dobav(key2,pas2);
            h.Dobav(key3,pas3);
            Assert.Contains(e,new[] {h.POISK(key3)});
        }
    }
}