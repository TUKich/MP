using System;
using mp3s;
using NUnit.Framework;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        [Test]
        [TestCase("Настя Света Максим Пудж"," Настя Света Максим Пудж")]
        [TestCase("Рома Sven"," Рома Sven")]
        [TestCase("Тимка Антоха Хлеб"," Тимка Антоха Хлеб")]
        public void TestFill(String name, String otvet)
        {
            Program p = new Program();
            String o =p.Fill(name);
            Assert.AreEqual(o,otvet);

        }

        [Test]
        [TestCase("Настя Света Максим Пудж","Пудж"," Настя Света Максим")]
        [TestCase("Рома Sven","Sven"," Рома")]
        [TestCase("Тимка Антоха Хлеб","Антоха"," Тимка Хлеб")]
        public void Remove(String name, String remove, String otvet)
        {
            Program p = new Program();
            String o = p.remove(name, remove);
            Assert.AreEqual(o,otvet);
        }

        [Test]
        [TestCase("Настя Света Максим Пудж"," Пудж Максим Света Настя")]
        [TestCase("Рома Sven"," Sven Рома")]
        [TestCase("Тимка Антоха Хлеб"," Хлеб Антоха Тимка")]
        public void Back(String name, String otvet)
        {
            Program p = new Program();
            String o =p.back(name);
            Assert.AreEqual(o,otvet);
        }

        [Test]
        [TestCase("Настя Света Максим Пудж","Света", true)]
        [TestCase("Рома Sven","Пудж",false)]
        [TestCase("Тимка Антоха Хлеб","Хлеб",true)]
        public void Contains(String name,String search, Boolean otvet)
        {
            Program p = new Program();
            Boolean o =p.con(name,search);
            Assert.AreEqual(o,otvet);
        }
    }
}