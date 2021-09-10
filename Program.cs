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
            for (int i = 0; i < 30; i++)
                numbers.Add(rand.Next(1, 21));
                Console.WriteLine("***"+ numbers.Count);
                Display(numbers);
                //Console.Read();
                //Console.Write(numbers);
        }
                 
        static void Display(List<int> list)             //Display method shows 50 number in each row in the form of a list
        {   
            for(int i = 0; i < list.Count; i++)
                if(i == 0)
                   Console.Write("[ "+ list[i] + ", ");
                else if((i+1) % 10 == 0 && i != (list.Count)-1)
                   Console.WriteLine(list[i] + ", ");
                
                else if (i == (list.Count)-1)
                   Console.Write(list[i] +" ]");
                else 
                   Console.Write(list[i] + ", ");
        }
    }
}
