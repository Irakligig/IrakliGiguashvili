using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureImplementations
{
    internal class Stack<T> : IEnumerable<T>
    {
        T[] _array;
        int top;

        public Stack(int amount)
        {
            _array = new T[amount];
            top = -1;
        }
        public bool IsEmpty()
        {
            if (top == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isFull()
        {
            if(top == _array.Length - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Push(T elem)
        {
            if (isFull())
            {
                Console.WriteLine("Not possible");
            }
            else
            {
                _array[top++] = elem;   
            }
        }

        public T pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Not possible");
                return default(T);
            }
            else
            {
                return _array[top--]; // ჯერ აქსესი ხდება და მერე ტოპის დაწევა , სანამ დარეთარნდება
            }
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                return default(T);
            }
            else
            {
                return _array[top];
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = top; i > 0; i--)
            {
                yield return _array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
           return GetEnumerator();
        }
    }
}
