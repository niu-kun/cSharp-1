using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    interface IListDS<T>
    {
        void SetData();
        void GetData();
        bool IsEmpty();
        int RemoveAt();
        void Insert(int index, T e);
        T delete(int index);
    }
}
