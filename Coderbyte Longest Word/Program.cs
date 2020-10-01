using System;
using System.Collections.Generic;
using System.Linq;

namespace Coderbyte_Longest_Word
{
    class Program
    {
        public static string LongestWord(string sen)
        {

            // code goes here 
            //var strList = sen.Split(' ');
            //string[] parts1 = sen.Split(new string[] { " ", "&" }, StringSplitOptions.RemoveEmptyEntries);
            var strList = sen.Split(new string[] { " ", "&","!","/",":","~" }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<int, string> dictList = new Dictionary<int, string>();
            for (int i = 0; i < strList.Length; i++)
            {
                dictList.Add(i, strList[i]);

            }
            var sortedList = SortByLength(strList);
            int len = sortedList.Count;
            if (sortedList?.Count > 1)
            {
                if (sortedList[0].Length == sortedList[1].Length)
                {
                    int indx1 = dictList.FirstOrDefault(x => x.Value == sortedList[0]).Key;
                    int indx2 = dictList.FirstOrDefault(x => x.Value == sortedList[1]).Key;
                    if (indx1 < indx2)
                    {
                        return sortedList[0];
                    }
                    return sortedList[1];

                }
                return sortedList[0];

            }
            else
            {
                return sortedList[0];
            }




        }
        public static List<String> SortByLength(IEnumerable<string> strList)
        {
            var sorted = from str in strList orderby str.Length descending select str;
            return sorted.ToList();
        }
        static void Main(string[] args)
        {
            var loop = int.Parse(Console.ReadLine());
            while (loop != 0)
            {
                Console.WriteLine(LongestWord(Console.ReadLine()));
                loop = loop - 1; ;
            }
            Console.ReadKey();
        }
    }
}
