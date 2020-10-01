using System;
using System.Collections.Generic;

namespace Tech9_Assement_code
{
    class Program
    {
        static void Main(string[] args)
        {


            var input = Console.ReadLine();
            var data = input.Split(' ');
            Console.WriteLine(ArrayChallenge(data));
            Console.ReadKey();
        }
        public static string ArrayChallenge(string[] strArr)
        {

            // code goes here  
            var firstIndexString = strArr[0];
            var secondIndexDictionary = strArr[1].Split(',');

            var listContain = new List<string>();
            foreach (var data in secondIndexDictionary)
            {
                if (firstIndexString.Contains(data))
                {
                    listContain.Add(data);
                }
            }
            listContain.Sort((a, b) => a.Length.CompareTo(b.Length));
            listContain.Reverse();
            //string data1 = firstIndexString;

            //var temp = firstIndexString.Split(new string[] { listContain[1] }, StringSplitOptions.None);
            //var rtuen = "";
            //foreach (var data in listContain)
            //{
            //    if (temp[1] == data)
            //    {
            //        rtuen = data;
            //        break;
            //    }
            //}
            if(listContain.Count<=1)
            {
                return "not possible";
            }
            return $"{listContain[0]},{listContain[1]}";

        }
    }
}
