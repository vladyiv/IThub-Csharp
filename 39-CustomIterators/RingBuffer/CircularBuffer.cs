using System;
using System.Collections.Generic;
using System.Text;

namespace CircularBuffer
{
    internal class CircularBuffer<T> : IEnumerable<T>
    {
        public T[] Content;
        public CircularBuffer(int i) => Content = new T[i];
        public Add(T item)
        {
            for (int i = 0; i <= Content.Length; i++)
            {
                if (Content[i] is null)
                {
                    Content[i] = item;
                    return;
                }
            }

        }
    }
}
