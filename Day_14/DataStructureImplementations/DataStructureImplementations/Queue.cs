using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureImplementations
{
    internal class Queue<T> : IEnumerable<T>
    {
        T[] _array;
        int head;
        int tail;
        int size;

        public Queue(int x) 
        {
            head = tail = -1;
            size = 0;
            _array = new T[x];  
        }  

        public bool IsEmpty()
        {
            if (size == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsFull()
        {
            if ((tail + 1) % _array.Length == head)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Enque(T x)
        {
            if (IsEmpty())
            {
                head = tail = 0; // -1 რომ აღარ იყოს ორივეს ინდექსი
            }
            else if (IsFull())
            {
                return; // არაფერს იზავს ეს ფუნქცია თუ სავსეა
            }
            else
            {
                tail = (tail + 1) % _array.Length;
            }
            size++;
            _array[tail] = x; // თუ აქამდე მოვიდა ესეიგი tail შეცვლილი არის და ჩაამატებს უბრალოდ
        }
        public T? Dequeue()
        {
            if (IsEmpty())
            {
                
                return default(T);
            }
            else
            {
                int temp = head;
                head = (head + 1) % _array.Length;
                size--;
                if (size == 0)
                {
                    head = tail = -1;
                }
                return _array[temp];
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
                return _array[head];
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < size; i++)
            {
                yield return _array[(head + i) % _array.Length];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
