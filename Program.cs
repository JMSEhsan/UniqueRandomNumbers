using System;
using System.Collections.Generic;

namespace UniqueRandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unique  Random Generator <1-10000>");
            Random rand = new Random();
            List<int> numbers = new List<int>();
                numbers.Add(rand.Next(1,101));
                Display(numbers);
                //Console.ReadKey();
                //Console.Write(numbers);
        }

        static void Display(List<int> list)
        {
            for(int i = 0; i < list.Count; ++i)
                if (i % 25 == 0)
                   Console.WriteLine();
                else
                   Console.Write(list[i] + " ");
        }
    }
}
