using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupScenario2
{
    class Program
    {
        /*
         * Create a program that will parse an equation from a string and print the result of the equation.
         * 
         * It should support the following symbols: ^, *, /, +, -
         * 
         * Here's an example of what your input and output would be:
         * 
         * y=x*2^2+2
         * 
         * and for 5 iterations, that would print out:
         * 
         * 1: 6
         * 2: 10
         * 3: 14
         * 4: 18
         * 5: 22
         * 
         * It should be able to accept X in any position, and even more than one X. (e.g. y=x*2^x+2)
         * if you want to omit the 'y=', that's fine, and your program can print the values in any format as long as they are correct. (please keep them to 1 iteration per line, though)
         * 
         * Use as many classes/methods as you need, your only restriction is that you may not edit this file.
         * 
         * If you finish this quickly, try adding the ability to use parenthesis!
         * 
         */
        static void Main(string[] args)
        {
            Parse myParse = new Parse();
            while (true)
            {
                Console.WriteLine("Input equation, or q to quit: ");
                string input = Console.ReadLine();
                if (input == "q") break;
                myParse.ParseString(input);
                myParse.GetResults(10);
            }
        }
    }
}
