using System;
using System.Text;
using System.Collections.Generic;

namespace UniqueRandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unique Random Generator <1 - 10000>:");
            Random rand = new Random();
            List<int> numbers = new List<int>();
            for (int i = 0; i < 20; i++)
                numbers.Add(rand.Next(1, 21));
                Console.WriteLine("***"+ numbers.Count);
                Display(numbers);
                //Console.Read();
                //Console.Write(numbers);
        }
                 
        static void Display(List<int> list)             //Display method shows 50 number in each row
        {   
            for(int i = 0; i < list.Count; i++)
                if(i % 10 == 0)
                   Console.WriteLine(list[i] + ", ");
                else
                   Console.Write(list[i] + ", ");
        }
    }
}
