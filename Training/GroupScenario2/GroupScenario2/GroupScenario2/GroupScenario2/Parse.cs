using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupScenario2
{
    public class Parse
    {
        string equationString;
        string[] equationNumberParts;
        string[] equationOperatorParts;

        char[] allowableCharacters = new char[19] { 'x', 'y', '=', '^', '*', '/', '+', '-', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
        char[] functionCharacters = new char[6] { '=', '^', '*', '/', '+', '-' };

        /// <summary>
        /// This is your input. Save your equation into this instance of the class.
        /// </summary>
        /// <param name="equation"></param>
        public void ParseString(string equation)
        {
            string tempEquation = equation.ToLower().Trim();
            if (tempEquation.Length == 0 || !CheckForInvalidChars(tempEquation))
            {
                equationString = null;
            }
            else
            {
                equationString = equation;
                equationNumberParts = equationString.Split(functionCharacters);
                

                equationOperatorParts = equationString.Split(equationNumberParts, StringSplitOptions.None);
                for (int i = 0; i < equationNumberParts.Length; i++)
                {
                    equationNumberParts[i] = equationNumberParts[i].Trim();
                }

                for (int i = 0; i < equationOperatorParts.Length; i++)
                {
                    equationOperatorParts[i] = equationOperatorParts[i].Trim();
                }
            }
        }

        public bool CheckForInvalidChars(string equation)
        {
            char[] tempEquationArray = equation.ToCharArray();
            bool validEquation = true;

            bool multiY = false;
            bool multiEqual = false;

            foreach(char c in tempEquationArray)
            {
                bool badEquation = true;

                foreach(char allowedChar in allowableCharacters)
                {
                    if (c == allowedChar || c == ' ')
                    {
                        if (c == 'y' && !multiY)
                        {
                            multiY = true;
                            badEquation = false;
                            break;
                        }
                        else if(c == 'y' && multiY)
                        {
                            break;
                        }
                        else if (c == '=' && !multiEqual)
                        {
                            multiEqual = true;
                            badEquation = false;
                            break;
                        }
                        else if(c == '=' && multiEqual)
                        {
                            break;
                        }
                        else
                        {
                            //Found the character, break out.
                            badEquation = false;
                            break;
                        }
                    }
                }

                if(badEquation)
                {
                    validEquation = false;
                    break;
                }
            }

            return validEquation;
        }


        /// <summary>
        /// Print one line for each iteration (i.e. for y=x*2 at 4 iterations:
        /// 1: 2
        /// 2: 4
        /// 3: 6
        /// 4: 8
        /// </summary>
        /// <param name="iterations"></param>
        public void GetResults(int iterations)
        {
            if(equationString == null)
            {
                Console.WriteLine("Invalid input.");
            }
            else
            {
                for(int i = 1; i <= iterations; i++)
                {
                    
                    Console.Write(i + ": " + "");
                }
            }
        }


    }
}
