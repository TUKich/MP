using MP2Seva;
using NUnit.Framework;
using System;

namespace TestProject
{
    [TestFixture]

    public class Tests
    {
        
        [Test]
        [TestCase(new long[]{1,2,3,4,5,6,7,8,9}, true)]
        [TestCase(new long[]{}, false)]
        [TestCase(new long[]{9,5,2,5,6,7,8,9,0,1}, true)]
        [TestCase(new long[]{1,2}, true)]
        public void TestQ(long[] cot, bool t)
        {
            Program p = new Program();
            bool a = p.Fill(cot);
            Assert.AreEqual(a, t);
        }

        [Test]
        [TestCase(new long[]{1,2,3,4,5,6,7,8,9},1,9, true)]
        [TestCase(new long[]{},0,0,false)]
        [TestCase(new long[]{9,5,2,5,6,7,8,9,0,1},9,1, true)]
        [TestCase(new long[]{1,2},1,2, true)]
        public void Out(long[] cot, long head, long tail, Boolean y)
        {
            Program p = new Program();
            
            Boolean b=p.Fill(cot);
            Boolean t = false;
            if (b)
            {
                if (head == p.OutputHead() && tail == p.OutputTail())
                {
                    t = true;
                    
                }
            }
            Assert.AreEqual(y,t);
        }

        [Test]
        [TestCase(new long[]{1,2,3,4,5,6,7,8,9}, false)]
        [TestCase(new long[]{}, true)]
        [TestCase(new long[]{9,5,2,5,6,7,8,9,0,1}, false)]
        [TestCase(new long[]{1,2}, false)]
        public void Em(long[] cot, Boolean t)
        {
            Program p = new Program();
            p.Fill(cot);
            Boolean a = p.TestEmpty();
            Assert.AreEqual(t,a);
        }
        [Test]
        [TestCase(new long[]{1,2,3,4,5,6,7,8,9}, true)]
        [TestCase(new long[]{}, false)]
        [TestCase(new long[]{9,5,2,5,6,7,8,9,0,1}, true)]
        [TestCase(new long[]{1,2}, true)]
        public void Fu(long[] cot, Boolean t)
        {
            Program p = new Program();
            p.Fill(cot);
            Boolean a = p.TestFull();
            Assert.AreEqual(t,a);
        }
        [Test]
        [TestCase(new long[]{1,2,3,4,5,6,7,8,9}, 1)]
        [TestCase(new long[]{}, 0)]
        [TestCase(new long[]{9,5,2,5,6,7,8,9,0,1}, 9)]
        [TestCase(new long[]{1,2}, 1)]
        public void Pee(long[] cot, long t)
        {
            Program p = new Program();
            p.Fill(cot);
            Assert.AreEqual(t,p.Peek());
        }
        
        
    }
    
    
    
    
    
}