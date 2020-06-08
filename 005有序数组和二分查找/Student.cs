
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace _005有序数组和二分查找
{
    class Student : IComparable<Student>
    {
        private string name;

        private double tall;

        public Student(string name, double tall)
        {
            this.name = name;
            this.tall = tall;
        }

        public override string ToString()
        {
            return "{" + name + "： " + tall + "}";
        }

        public int CompareTo(Student other)
        {
            if (this.tall > other.tall) return 1;
            else if (this.tall < other.tall) return -1;
            else return 0;
        }
    }
}
