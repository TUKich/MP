using System;
using lb4;
using NUnit.Framework;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        [TestCase("User1", "1234", "User2", "89123", "User3", "ueuwq", true)]
        public void Test1(string User1, string pas1, string User2, string pas2, string User3, string pas3, bool e)
        {
            Program h = new Program();
            h.AddHT(User1,pas1);
            h.AddHT(User2,pas2);
            h.AddHT(User3,pas3);
            bool Ac = 
            Assert.Contains(e,);
        }
    }
}