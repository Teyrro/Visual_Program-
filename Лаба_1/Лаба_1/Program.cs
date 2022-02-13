using System;
using Laba_1;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            HW1 test = new HW1();
            int[] a = { 5, 3, 4 };
            Console.WriteLine(test.QueueTime(a, 1));
        }
    }
}
