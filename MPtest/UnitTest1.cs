using MP;
using NUnit.Framework;
using System;

namespace MPtest
{
    [TestFixture]

    public class Tests
    {
        [Test]
        public void PopadaniaVTochku()
        {
            Program p = new Program(6,9);
            bool expected = true;
            bool actual = p.Tochka(7,0);
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        [Microsoft.VisualStudio.TestTools.UnitTesting.ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IsInAreaTest_NegativeRadiusThrowsException()
        {
            Program p = new Program(6,9);
            p.R1 = -1;
            p.R2 = -1;
        }

        [Test]
        [TestCase(6,9,7,0,true)]
        [TestCase(6,9,4,4,false)]
        [TestCase(1,2,9,9,false)]
        [TestCase(1,2,1,1,true)]
        public void IsInAreaTest_PointsOnCurves_InArea(int R1, int R2,  int x, int y, bool expected)
        {
            Program p = new Program(R1, R2);
            bool actual = p.Tochka(x, y);
            Assert.AreEqual(expected, actual);
        }
    }
}