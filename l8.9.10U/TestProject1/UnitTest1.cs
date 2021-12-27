using l8._9._10U;
using NUnit.Framework;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace TestProject1
{
    public class Tests
    {
        [TestClass]
    public class RingBufferTests {

        private int iterations = 1000;

        private int knownValue = 1;

        [TestMethod()]
        public void PutIncrementsSize() {
            RingBuffer<int> _buffer = new RingBuffer<int>(iterations);
            for(int i = 0; i < iterations; i++) {
                int _tmp = i;
                _buffer.Add(_tmp);
                Assert.AreEqual(i + 1, _buffer.Size, "Size is not equal to number of elements added.");
            }
        }

        [TestMethod()]
        public void GetDecrementsSize() {
            RingBuffer<int> _buffer = new RingBuffer<int>(iterations);
            populateBuffer(iterations, _buffer);
            for(int i = iterations; i > 0; i--) {
                int _tmp = _buffer.Get();
                Assert.AreEqual(i-1, _buffer.Size, "Size does not reflect the correct number of removed elements.");
            }
        }

        [TestMethod()]
        public void RetrievedInCorrectOrder() {
            RingBuffer<int> _buffer = new RingBuffer<int>(iterations);
            populateBuffer(iterations, _buffer);
            for(int i = 0; i < iterations; i++) {
                int _tmp = _buffer.Get();
                Assert.AreEqual(i, _tmp, "Incorrect Sequence");
            }
        }
        [TestMethod(), ExpectedException(typeof(InvalidOperationException))]
        public void ThrowsError_GetEmpty() {
            RingBuffer<byte> buffer = new RingBuffer<byte>();
            byte _tmp = buffer.Get();
        }
        [TestMethod()]
        public void CanIterateForeach() {
            RingBuffer<int> buffer = new RingBuffer<int>(iterations);
            populateBuffer(iterations, buffer);
            int _iterations = 0;
            foreach(int i in buffer){
                _iterations++;
            }
            Assert.AreEqual(iterations, _iterations, "Wrong number of foreach iterations.");
        }
        [TestMethod()]
        public void ContainsReturnsCorrectly() {
            RingBuffer<int> _buffer = new RingBuffer<int>(iterations + 2);
            _buffer.Add(knownValue - 1);
            bool _containsKnownValue = _buffer.Contains(knownValue);
            Assert.AreEqual(false, _containsKnownValue);
            populateBuffer(iterations, _buffer);
            _buffer.Add(knownValue);
            _containsKnownValue = _buffer.Contains(knownValue);
            Assert.AreEqual(true, _containsKnownValue);

        }
        [TestMethod()]
        public void ClearAsExpected() {
            RingBuffer<int> _buffer = new RingBuffer<int>(iterations);
            populateBuffer(iterations, _buffer);
            _buffer.Clear();
            Assert.AreEqual(0, _buffer.Count);
        }
        [TestMethod()]
        public void CopyToTest() {
            RingBuffer<int> _buffer = new RingBuffer<int>(iterations);
            populateBuffer(iterations, _buffer);
            int[] _array = new int[iterations + 1];
            _buffer.CopyTo(_array, 1);
            Assert.AreEqual(default(int), _array[0]);
            for(int i = 1; i < _array.Length; i++) {
                Assert.AreEqual(i - 1, _array[i]);
            }
        }

        [TestMethod()]
        public void ItemIsRemoved() {
            RingBuffer<int> _buffer = new RingBuffer<int>(iterations);
            populateBuffer(iterations, _buffer);
            int _preRemoveSize = _buffer.Count;
            _buffer.Remove(0);
            Assert.AreEqual(false, _buffer.Contains(0));
            Assert.AreEqual(_preRemoveSize - 1, _buffer.Count);

        }
        private void populateBuffer(int elements, RingBuffer<int> buffer) {
            for(int i = 0; i < elements; i++) {
                buffer.Add(i);
            }
        }
    }
    }
}