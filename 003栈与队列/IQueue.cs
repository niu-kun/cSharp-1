using System;
using System.Collections.Generic;
using System.Text;

namespace _003栈与队列
{
    interface IQueue<E>
    {
        void Enqueue(E e);

        E Dequeue();

        E Peek();

        int Count { get; }

        bool IsEmpty { get; }
    }
}
