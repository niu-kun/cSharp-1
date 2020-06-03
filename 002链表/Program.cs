using System;
using System.Collections.Generic;

namespace _002链表
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList1<int> l = new LinkedList1<int>();
            for(int i = 0; i < 5; i++)
            {
                l.AddFirst(i);
                Console.WriteLine(l);
            }

            l.AddLast(666);
            Console.WriteLine(l);

            l.Add(2, 9);
            Console.WriteLine(l);

            l.Set(2, 1000);
            Console.WriteLine(l);


            Console.Read();

        }
    }
}
