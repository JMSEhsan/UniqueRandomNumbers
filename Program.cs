using System;
using System.Collections.Generic;

namespace UniqueRandomNumbers
{
    class Program
    {
        static void Main(string[] args)                                     // Main Method to generate unique random numbers
        {   
            Console.WriteLine("Unique Random Number Generator < 1 - 10000 >:");
            Random rand = new Random();
            List<int> numbers = new List<int>();
            int newRandom;
            int i = 1;
            numbers.Add(rand.Next(1,10001));
            while(i<10000)
            {
                newRandom = rand.Next(1,10001);
                for (int j = 0; j < (numbers.Count); j++)
                {
                   if(newRandom != numbers[i-1] && j == numbers.Count-1)
                   {
                     ++i;
                     numbers.Add(newRandom);
                     break;
                   }
                   else if ( newRandom == numbers[j])
                     break;

                    //else does nothing
                 }
            }

            Console.WriteLine("List numbers count: "+ numbers.Count); 
            Display(numbers);
        }
                 
        static void Display(List<int> list)             //Display method shows 25 number in each row in the form of a list.
        {   
            for(int i = 0; i < list.Count; i++)
                if(i == 0)
                   Console.Write("[ "+ list[i] + ", ");
      
                else if((i+1) % 25 == 0 && i != (list.Count)-1)
                   Console.WriteLine(list[i] + ", ");
                
                else if (i == (list.Count)-1)
                   Console.Write(list[i] +" ]");
                   
                else 
                   Console.Write(list[i] + ", ");
        }
    }
}
