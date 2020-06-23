
using System;
using System.Collections.Generic;
using System.Text;

namespace _008哈希表
{
    public interface ISet1<E>
    {
        int Count { get; }

        bool IsEmpty { get; }

        void Add(E e);

        void Remove(E e);

        bool Contains(E e);
    }
}
