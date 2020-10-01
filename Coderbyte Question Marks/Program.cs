using System;

namespace Coderbyte_Question_Marks
{
    class Program
    {
        public static string QuestionsMarks(string str)
        {

            // code goes here  
            bool returnVal = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    int firstNumber = int.Parse(str[i].ToString());
                    for (int j = i + 1; j < str.Length; j++)
                    {
                        if (char.IsDigit(str[j]))
                        {
                            int secondNumber = int.Parse(str[j].ToString());
                            if ((firstNumber + secondNumber) == 10)
                            {
                                int quesMark = 0;
                                for (int k = i + 1; k < j; k++)
                                {
                                    if (str[k] == '?')
                                    {
                                        quesMark = quesMark + 1;
                                    }
                                }
                                if (quesMark == 3)
                                {
                                    returnVal = true;
                                    break;
                                }
                                else
                                {
                                    return false.ToString().ToLower();
                                }
                            }
                        }
                    }
                }
            }
            return returnVal.ToString().ToLower();
        }
        static void Main(string[] args)
        {
            // keep this function call here
            Console.WriteLine(QuestionsMarks(Console.ReadLine()));
            Console.Read();
        }
    }
}
