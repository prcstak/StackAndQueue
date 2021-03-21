using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    class MyQueue
    {
        int[] mas;
        int lastPos;
        int topPos;
        int n = 8;
        public int count = 0;

        public MyQueue()
        {
            mas = new int[n];
            lastPos = 0;
            topPos = 0;
        }

        public void PushF(int elem)
        {
            mas[lastPos++] = elem;
            count++;
        }
            public void Push(int elem)
        {
            if (lastPos != topPos)
            {
                mas[lastPos] = elem;
                count++;
            }
            else
            {
                int[] nMas = new int[n*2]; 
                for (int i=0; i<n; i++)
                {
                    nMas[i] = mas[lastPos];
                    lastPos = (1 + lastPos) % n;
                }
                nMas[lastPos] = elem;
                mas = nMas;
                count++;
                n *= 2;
            }
            lastPos = (1 + lastPos) % n;
        }

        public int Pop()
        {
            var a = mas[topPos];
            mas[topPos] = default;
            topPos = (topPos + 1) % n;
            count--;
            return a;
        }

        public override string ToString()
        {
            var b = new StringBuilder();
            for (int i = 0; i<count; i++)
            {
                //if (mas[(position + i) % n] != default)
                    b.Append($"[{mas[(topPos + i) % n]}] ");
            }
            
            return b.ToString();
        }
    }
}
