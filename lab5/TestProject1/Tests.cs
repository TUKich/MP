using System;
using lab5;
using NUnit.Framework;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {

            [TestCase(1.0 , 1.0 , 3.0 , true)]
            [TestCase(0.0 , 0.0 , 1.0 , true)]
           public void Test0(double x, double y,double R ,Boolean expectation)
            {
                Program p = new Program();
                Assert.AreEqual(expectation, p.CheckPoints(x, y, R));
            }

            
            
            [TestCase(-6.0 , 6.0 , 1.0 , false)]
            [TestCase(10.0 , -9.0 , 0.0 , false)]
            public void Test01(double x, double y,double R ,Boolean expectation)
            {
                Program p = new Program();
                Assert.AreEqual(expectation, p.CheckPoints(x, y, R));
            }
          
            [TestCase(4.0 , 0.0 , 4.0 , true)]
            [TestCase(0.0 , 4.0 , 4.0 , true)]
            public  void Test02(double x, double y,double R ,Boolean expectation)
            {
                Program p = new Program();
                Assert.AreEqual(expectation, p.CheckPoints(x, y, R));
            }
            
        }
        
    }
