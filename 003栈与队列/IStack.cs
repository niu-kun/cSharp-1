using System;
using System.Collections.Generic;
using System.Text;

namespace _003栈与队列
{
    interface IStack<E>
    {
        int Count { get; }

        bool IsEmpty { get; }

        void Push(E e);

        E Pop();

        E GetPeek();
    }
}
