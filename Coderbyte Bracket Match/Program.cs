using System;

/*
 *Bracket Matcher
Hide Question
Have the function BracketMatcher(str) take the str parameter being passed and return 1 if the brackets are correctly matched and each one is accounted for. Otherwise return 0. For example: if str is "(hello (world))", then the output should be 1, but if str is "((hello (world))" the the output should be 0 because the brackets do not correctly match up. Only "(" and ")" will be used as brackets. If str contains no brackets return 1.

Use the Parameter Testing feature in the box below to test your code with different arguments.
*/

namespace Coderbyte_Bracket_Match
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BracketMatcher(Console.ReadLine()));
            Console.ReadKey();
        }
        public static string BracketMatcher(string str)
        {

            // code goes here
            int bracketL = 0;
            int bracketR = 0;
            int output = 0;
            if (str.Contains("(") || str.Contains(")"))
            {
                foreach (var ch in str)
                {
                    if (ch == '(')
                    {
                        bracketL = bracketL + 1;
                    }
                    if (ch == ')')
                    {
                        bracketR = bracketR + 1;
                    }
                    if (bracketL < bracketR)
                    {
                        output = 0;
                        break;
                    }
                }
            }
            else
            {
                output = 1;
            }
            if (bracketL == bracketR)
            {
                output = 1;
            }
            else
            {
                output = 0;
            }

            return output.ToString();

        }
    }
}
