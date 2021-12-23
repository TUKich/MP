
using l6u;
using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        [TestCase("TUK", "UVL")]
        [TestCase("ROOT", "SPPU")]
        [TestCase("VOPROS", "WPQSPT")]
        public void Test1(string s1, string s2)
        {
            Program p = new Program();
            Assert.AreEqual(true, s2.Equals(p.Testik(s1)) );
        }
    }
}
