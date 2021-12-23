using System;
using lu3;
using NUnit.Framework;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        [TestCase("12 51325 1 676789"," 12 51325 1 676789")]
        [TestCase("6969 7878"," 6969 7878")]
        [TestCase("321 123 213"," 321 123 213")]
        public void TestFill(String name, String otvet)
        {
            MyClass p = new MyClass();
            String o =p.Fill(name);
            Assert.AreEqual(o,otvet);

        }

        
        [TestCase("12 51325 1 676","676"," 12 51325 1")]
        [TestCase("6969 7878","7878"," 6969")]
        [TestCase("321 123 213","123"," 321 213")]
        public void Remove(String name, String remove, String otvet)
        {
            MyClass p = new MyClass();
            String o = p.remove(name, remove);
            Assert.AreEqual(o,otvet);
        }

        [TestCase("12 51325 1 676","1", true)]
        [TestCase("6969 7878","676789",false)]
        [TestCase("321 123 213","213",true)]
        public void Contains(String name,String search, Boolean otvet)
        {
            MyClass p = new MyClass();
            Boolean o =p.con(name,search);
            Assert.AreEqual(o,otvet);
        }
    }
}