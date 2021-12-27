namespace l8._9._10U
{
    public class GrowingRingBuffer<T> : RingBuffer<T> {
        private int originalCapacity;
        public new void Put(T item) {
            if(tail == head && size != 0) {
                T[] _newArray = new T[buffer.Length + originalCapacity];
                for(int i = 0; i < Capacity; i++) {
                    _newArray[i] = buffer[i];
                }
                buffer = _newArray;
                tail = (head + size) % Capacity;
                addToBuffer(item, false);
            }
            else {
                addToBuffer(item, false);
            }
        }

        public GrowingRingBuffer() : this(4) { }
        public GrowingRingBuffer(int startCapacity)
            : base(startCapacity) {
            originalCapacity = startCapacity;
        }
      
    }
}