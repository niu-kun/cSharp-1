using System;

namespace _006二叉查找树和递归
{
    class Program
    {
        public static int Func(int n)
        {
            if (n == 1) return 1;
            else return n * (n - 1);
        }


        static void Main(string[] args)
        {


            Console.WriteLine(Func(2));
            Console.WriteLine(Func(6));

















            Console.Read();
        }
    }
}
