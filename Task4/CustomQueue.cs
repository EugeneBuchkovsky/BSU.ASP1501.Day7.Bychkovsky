using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class CustomQueue<T> : IEnumerable<T>
    {
        private T[] values;
        private int head, tail, size, capacity, defaultCapacity;

        public int Count {get {return values.Length; }}

        public T this[int index]
        {
            get { return values[index]; }
            set { values[index] = value; }
        }

        public CustomQueue(T[] array)
        {
            if (array != null)
            {
                //values = new T[array.Length];
                values = (T[])array.Clone();
                this.defaultCapacity = array.Length + 10;
                this.tail = values.Length - 1;
                this.size = values.Length;
            }
            else
            {
                values = new T[0];
                this.defaultCapacity = 10;
                this.tail = 0;
                this.size = 0;
            }
            this.capacity = defaultCapacity;
            this.head = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new CustomIterator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }


        public struct CustomIterator : IEnumerator<T>
        {
            private readonly CustomQueue<T> queue;
            private int pointer;

            public CustomIterator(CustomQueue<T> queue)
            {
                this.pointer = -1;
                this.queue = queue;
            }


            public T Current
            {
                get
                {
                    if (pointer < 0 || pointer > queue.Count)
                        throw new InvalidOperationException();
                    return queue[pointer];
                }
            }

            public bool MoveNext()
            {
                if (pointer < queue.Count)
                {
                    pointer++;
                    return true;
                }
                return false;
            }

            public void Reset()
            {
                pointer = -1;
            }
        }

 

        public T Peek()
        {
            if (Count > 0)
                return values[0];
            throw new InvalidOperationException("Queue is empty.");
        }

        public void Enqueue(T newElement)
        {
            if (this.size == this.capacity)
            {
                T[] newQueue = new T[2 * capacity];
                Array.Copy(values, 0, newQueue, 0, values.Length);
                values = newQueue;
                capacity *= 2;
            }
            size++;
            values[tail++ % capacity] = newElement;
        }

        public T Dequeue()
        {
            if (this.size == 0)
            {
                throw new InvalidOperationException();
            }
            size--;
            return values[++head % capacity];
        }

    }
}
