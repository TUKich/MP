using System;
using System.Collections;
using System.Collections.Generic;

namespace l8._9._10U
{
    public class RingBuffer<T> : IEnumerable<T>, IEnumerable, ICollection {
        protected int head = 0;
        protected int tail = 0;
        protected int size = 0;
        protected T[] buffer;
        private bool allowOverflow;
        public bool AllowOverflow { get { return allowOverflow; } }
        public int Capacity { get { return buffer.Length; } }
        public int Size { get { return size; } }
        public T Get() {
            if(size == 0) throw new System.InvalidOperationException("Buffer is empty.");
            T _item = buffer[head];
            head = (head + 1) % Capacity;
            size--;
            return _item;
        }
        public void Put(T item) {
            if(tail == head && size != 0) {
                if(allowOverflow) {
                    addToBuffer(item, true);
                }
                else {
                    throw new System.InvalidOperationException("The RingBuffer is full");
                }
            }
            else {
                addToBuffer(item, false);
            }
        }
        protected void addToBuffer(T toAdd, bool overflow) {
            if(overflow) {
                head = (head + 1) % Capacity;
            }
            else {
                size++;
            }
            buffer[tail] = toAdd;
            tail = (tail + 1) % Capacity;
        }
        
        public RingBuffer() : this(4) { }

        public RingBuffer(int capacity) : this(capacity, false) { }

        public RingBuffer(int capacity, bool overflow) {
            buffer = new T[capacity];
            allowOverflow = overflow;
        }
        public IEnumerator<T> GetEnumerator() {
            int _index = head;
            for(int i = 0; i < size; i++, _index = (_index + 1) % Capacity) {
                yield return buffer[_index];
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator() {
            return GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return (IEnumerator)GetEnumerator();
        }
        public int Count { get { return size; } }
        public bool IsReadOnly { get { return false; } }

        public void Add(T item) {
            Put(item);
        }

        public bool Contains(T item) {
            EqualityComparer<T> comparer = EqualityComparer<T>.Default;
            int _index = head;
            for(int i = 0; i < size; i++, _index = (_index + 1) % Capacity) {
                if(comparer.Equals(item, buffer[_index])) return true;
            }
            return false;
        }

        public void Clear() {
            for(int i = 0; i < Capacity; i++) {
                buffer[i] = default(T);
            }
            head = 0;
            tail = 0;
            size = 0;
        }
        public void CopyTo(T[] array, int arrayIndex) {
            int _index = head;
            for(int i = 0; i < size; i++, arrayIndex++, _index = (_index + 1) %
                Capacity) {
                array[arrayIndex] = buffer[_index];
            }
        }
        public bool Remove(T item) {
            int _index = head;
            int _removeIndex = 0;
            bool _foundItem = false;
            EqualityComparer<T> _comparer = EqualityComparer<T>.Default;
            for(int i = 0; i < size; i++, _index = (_index + 1) % Capacity) {
                if(_comparer.Equals(item, buffer[_index])) {
                    _removeIndex = _index;
                    _foundItem = true;
                    break;
                }
            }
            if(_foundItem) {
                T[] _newBuffer = new T[size - 1];
                _index = head;
                bool _pastItem = false;
                for(int i = 0; i < size - 1; i++, _index = (_index + 1) % Capacity) {
                    if(_index == _removeIndex) {
                        _pastItem = true;
                    }
                    if(_pastItem) {
                        _newBuffer[_index] = buffer[(_index + 1) % Capacity];
                    }
                    else {
                        _newBuffer[_index] = buffer[_index];
                    }
                }
                size--;
                buffer = _newBuffer;
                return true;
            }
            return false;
        }
        public Object SyncRoot { get { return this; } }


        public bool IsSynchronized { get { return false; } }

        void ICollection.CopyTo(Array array, int index) {
            CopyTo((T[])array, index);
        }
        
    }

    class MyClass
    {
        public static void Main(String[] args){}
    }
}