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
        private readonly T[] values;

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
                values = new T[array.Length];
                values = (T[])array.Clone();
            }
            values = new T[0];
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

    }
}
