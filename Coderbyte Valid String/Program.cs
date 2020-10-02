using System;
using System.Linq;
/*
 * Codeland Username Validation
Have the function CodelandUsernameValidation(str) take the str parameter being passed and determine if the string is a valid username according to the following rules:

1. The username is between 4 and 25 characters.
2. It must start with a letter.
3. It can only contain letters, numbers, and the underscore character.
4. It cannot end with an underscore character.

If the username is valid then your program should return the string true, otherwise return the string false.
Examples
Input: "aa_"
Output: false
Input: "u__hello_world123"
Output: true
 */

namespace Coderbyte_Valid_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CodelandUsernameValidation(Console.ReadLine()));
        }
        public static string CodelandUsernameValidation(string str)
        {

            // code goes here  
            string returnString = true.ToString().ToLower();
            int len = str.Length;
            if (len < 4 || len > 25)
            {
                returnString = false.ToString().ToLower();
            }
            if (!char.IsLetter(str[0]))
            {
                returnString = false.ToString().ToLower();
            }
            if (str[len - 1] == '_')
            {
                returnString = false.ToString().ToLower();
            }
            bool validString = str.All(c => Char.IsLetterOrDigit(c) || c.Equals('_')); ;
            if (!validString)
            {
                returnString = false.ToString().ToLower();
            }
            return returnString;

        }
    }
}
