using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    class MyStack<T> where T: IComparable
    {
        T[] mas;
        public int count;

        public MyStack()
        {
            mas = new T[8];
            count = 0;
        }

        public void Push(T newElem)
        {
            if (count++ <= 7)
            {
                mas[count] = newElem;
            }
            else
            {
                T[] nMas = new T[count * 2];
                for (int i = 0; i <= count - 1; i++)
                {
                    nMas[i] = mas[i];
                }
                nMas[count] = newElem;
                mas = nMas;
            }
        }

        public T Pop()
        {
            var el = mas[count];
            mas[count--] = default(T);
            return el;
        }

        public override string ToString()
        {
            var b = new StringBuilder();
            for(int i = 0; i<=count; i++)
            {
                b.Append($"[{mas[i]}] ");
            }
            return b.ToString();
        }
    }
}
