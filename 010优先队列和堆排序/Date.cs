
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace _010优先队列和堆排序
{
    class Date : IComparable<Date>
    {
        private readonly int year;
        private readonly int month;
        private readonly int day;
        private readonly string happen;

        public Date(int year, int month, int day, string happen)
        {
            this.year = year;
            this.month = month;
            this.day = day;
            this.happen = happen;
        }

        public int CompareTo([AllowNull] Date other)
        {
            if (this.year > other.year) return 1;
            if (this.year < other.year) return -1;
            if (this.month > other.month) return 1;
            if (this.month < other.month) return -1;
            if (this.day > other.day) return 1;
            if (this.day < other.day) return -1;
            return 0;
        }

        public override string ToString()
        {
            return year + "/" + month + "/" + day + ": " + happen;
        }
    }
}
