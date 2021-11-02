using System;
using NUnit.Framework;
using lab2Ed;
namespace TestProject1
{
    [TestFixture]

    public class Tests
    {

        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, true)]
        [TestCase(new int[] { }, false)]
        [TestCase(new int[] { 9, 5, 2, 5, 6, 7, 8, 9, 0, 1 }, true)]
        [TestCase(new int[] { 1, 2 }, true)]
        public void TestQ(int[] cot, bool t)
        {
            Program p = new Program();
            bool a = p.Fill(cot);
            Assert.AreEqual(a, t);
        }

        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 1, 9, true)]
        [TestCase(new int[] { }, 0, 0, false)]
        [TestCase(new int[] { 9, 5, 2, 5, 6, 7, 8, 9, 0, 1 }, 9, 1, true)]
        [TestCase(new int[] { 1, 2 }, 1, 2, true)]
        public void Out(int[] cot, int head, int tail, Boolean y)
        {
            Program p = new Program();

            Boolean b = p.Fill(cot);
            Boolean t = false;
            if (b)
            {
                if (head == p.OutputHead() && tail == p.OutputTail())
                {
                    t = true;

                }
            }
            Assert.AreEqual(y, t);
        }

        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, false)]
        [TestCase(new int[] { }, true)]
        [TestCase(new int[] { 9, 5, 2, 5, 6, 7, 8, 9, 0, 1 }, false)]
        [TestCase(new int[] { 1, 2 }, false)]
        public void Em(int[] cot, Boolean t)
        {
            Program p = new Program();
            p.Fill(cot);
            Boolean a = p.TestEmpty();
            Assert.AreEqual(t, a);
        }
        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, true)]

        [TestCase(new int[] { 9, 5, 2, 5, 6, 7, 8, 9, 0, 1 }, true)]
        [TestCase(new int[] { 1, 2 }, true)]
        public void Fu(int[] cot, Boolean t)
        {
            Program p = new Program();
            p.Fill(cot);
            Boolean a = p.TestFull();
            Assert.AreEqual(t, a);
        }
        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 1)]

        [TestCase(new int[] { 9, 5, 2, 5, 6, 7, 8, 9, 0, 1 }, 9)]
        [TestCase(new int[] { 1, 2 }, 1)]
        public void Pee(int[] cot, long t)
        {
            Program p = new Program();
            p.Fill(cot);
            Assert.AreEqual(t, p.Peek());
        }


    }

    
}