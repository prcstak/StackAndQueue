using System;
using System.Collections.Generic;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<char, char>
            {
                {'(', ')' },
                {'{', '}' },
                {'[', ']' },
                {'<', '>' }
            };

            var testline = "<div{0}(mas[0], mas[1])>";

            Console.WriteLine(Сompleteness(dict, testline));

            int[] mas = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            FromEvenToUneven(mas);
        }
       
        private static bool Сompleteness(Dictionary<char, char> dict, string line)
        {
            var S = new MyStack<char>();
            foreach (char lit in line)
            {
                foreach (var pair in dict)
                {
                    if (pair.Key == lit)
                    {
                        S.Push(lit);
                    }
                    if (pair.Value == lit)
                        if (pair.Key != S.Pop())
                            S.Push(' ');
                }
            }
            return S.count == 0;
        }
        
        private static void FromEvenToUneven(int[] mas)
        {
            var Q = new MyQueue();
            for (int i = 0; i < 10; i++)
            {
                if (mas[i] % 2 != 0)
                {
                    Q.Push(mas[i]);
                }
                else
                {
                    Console.Write($"{mas[i]} ");
                }
            }
            while (Q.count != 0)
            {
                var ch = Q.Pop();
                Console.Write($"{ch} ");
            }
        }
    }
}
