using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 5, 3, 2, 4 };
            ArraySolutions<int>.InsertAtFirst(10, arr);
            Console.WriteLine("Hello, Arrays!");
        }
    }
}
