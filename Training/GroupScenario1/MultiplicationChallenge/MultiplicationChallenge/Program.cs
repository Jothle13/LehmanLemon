using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MultiplicationChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 0;
            bool run = true;
            while (run)
            {
                Console.Write("Number 1: ");
                try
                {
                    num1 = Convert.ToInt32(Console.ReadLine());
                    run = false;
                }
                catch { Console.WriteLine("Invalid number, please try again."); }
            }
            run = true;
            while (run)
            {
                Console.Write("Number 2: ");
                try
                {
                    num2 = Convert.ToInt32(Console.ReadLine());
                    run = false;
                }
                catch { Console.WriteLine("Invalid number, please try again."); }
            }

            NumberResults(num1, num2);
            Console.ReadKey();
        }

        /*
         * Your function will be given 2 numbers.
         * It should print out every possible order of the resulting combinations.
         * 
         * For example: For 5 and 6:
         * 
         * 5 * 6 = 30
         * 
         * it will print out this:
         * 
         * 30
         * 03 (30 backwards)
         * 
         * for 20 and 12:
         * 
         * 20 * 12 = 240
         * 
         * it will print out this:
         * 
         * 240
         * 420
         * 042
         * 402
         * 204
         * 024
         * 
         */

        static void NumberResults(int number1, int number2)
        {
            int intSolution = number1 * number2;
            string strSolution = intSolution.ToString();


            if (strSolution.Length > 2)
            {
                // Print String Permutations
                for (int i = 0; i < strSolution.Length; i++)
                {
                    string firstNum = strSolution.Substring(i, 1);

                    if (i > 0 && i != strSolution.Length - 1)
                    {
                        string remainingNum = strSolution.Substring(0, i);
                        remainingNum = remainingNum + strSolution.Substring(i + 1, strSolution.Length - (i+1));
                        Builder(firstNum, remainingNum);
                    }
                    else if (i == strSolution.Length - 1)
                    {
                        // index is last number
                        string remainingNum = strSolution.Substring(0, i);
                        Builder(firstNum, remainingNum);
                    }
                    else
                    {
                        // index is first number
                        string remainingNum = strSolution.Substring(i + 1, strSolution.Length - 1);
                        Builder(firstNum, remainingNum);
                    }
                }
            }
            else if(strSolution.Length == 2)
            {
                Console.WriteLine(strSolution);
                char[] chrSolution = strSolution.ToCharArray();
                Console.WriteLine(chrSolution[1].ToString() + chrSolution[0].ToString());
            }
            else
            {
                Console.WriteLine(strSolution);
            }
        }

        static void Builder(string frontNums, string remainingComponents)
        {
            if (remainingComponents.Length == 1)
            {
                string solution = frontNums + remainingComponents;
                Console.WriteLine(solution);
            }
            else
            {
                for (int i = 0; i < remainingComponents.Length; i++)
                {
                    string newFrontNums = frontNums + remainingComponents.Substring(i, 1);
                    if (i > 0 && i != remainingComponents.Length - 1)
                    {
                        string remainingNum = remainingComponents.Substring(0, i);
                        remainingNum = remainingNum + remainingComponents.Substring(i + 1, remainingComponents.Length - (i + 1));
                        Builder(newFrontNums, remainingNum);
                    }
                    else if (i == remainingComponents.Length - 1)
                    {
                        // index is last number
                        string remainingNum = remainingComponents.Substring(0, i);
                        Builder(newFrontNums, remainingNum);
                    }
                    else
                    {
                        // index is first number
                        string remainingNum = remainingComponents.Substring(i + 1, remainingComponents.Length - 1);
                        Builder(newFrontNums, remainingNum);
                    }
                }
            }
        }
    }
}
