﻿using System;
using l8._9._10E.SimpleAlgorithmsApp;
using NUnit.Framework;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        [Test]
        [TestCase("12 5132534634 1 676789"," 12 5132534634 1 676789")]
        [TestCase("6969 7878"," 6969 7878")]
        [TestCase("321 123 213"," 321 123 213")]
        public void TestFill(String name, String otvet)
        {
            Program p = new Program();
            String o =p.Fill(name);
            Assert.AreEqual(o,otvet);

        }

        [Test]
        [TestCase("12 5132534634 1 676789","676789"," 12 5132534634 1")]
        [TestCase("6969 7878","7878"," 6969")]
        [TestCase("321 123 213","123"," 321 213")]
        public void Remove(String name, String remove, String otvet)
        {
            Program p = new Program();
            String o = p.remove(name, remove);
            Assert.AreEqual(o,otvet);
        }
        

        [Test]
        [TestCase("12 5132534634 1 676789","1", true)]
        [TestCase("6969 7878","676789",false)]
        [TestCase("321 123 213","213",true)]
        public void Contains(String name,String search, Boolean otvet)
        {
            Program p = new Program();
            Boolean o =p.con(name,search);
            Assert.AreEqual(o,otvet);
        }
        [Test]
        [TestCase("1 5 4 5",10)]
        [TestCase("12 12 16 16",192)]
        [TestCase("2 2",2)]
        public void AVg(String name, long otvet)
        {
            Program p = new Program();
            Boolean o =otvet==p.AVG(name);
            Assert.AreEqual(o,true);
        }
    }
}