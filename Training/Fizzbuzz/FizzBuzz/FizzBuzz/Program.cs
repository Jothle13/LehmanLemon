using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 100;
            FizzBuzz(number);
            Console.ReadKey();
        }
        /*
         * This program will recieve int X and print all numbers from 1-x 
         * (if x is 3 it would say:
         * 1
         * 2
         * 3)
         * 
         * Here's the catch: \
         * Numbers that are divisible by 3 will be replaced with Fizz
         * Numbers that are divisible by 5 will be replaced with Buzz
         * Numbers that are divisible by both will be replaced with FizzBuzz
         * 
         */
        static void FizzBuzz(int x)
        {
            for(int i = 1; i <= x; i++)
            {

                if(i%5 == 0 && i%3 == 0)
                {
                    for(int j = 0; j < i/5; j++)
                    {
                        Console.Write("FizzBuzz");
                    }

                    int fizzRemainder = (i/3) - (i/5);
                    for(int j = 0; j < fizzRemainder; j++)
                    {
                        Console.Write("Fizz");
                    }
                    Console.WriteLine();
                }
                else if(i % 3 == 0)
                {
                    for (int j = 0; j < i / 3; j++)
                    {
                        Console.Write("Fizz");
                    }
                    Console.WriteLine();
                }
                else if(i % 5 == 0)
                {
                    for (int j = 0; j < i / 5; j++)
                    {
                        Console.Write("Buzz");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
