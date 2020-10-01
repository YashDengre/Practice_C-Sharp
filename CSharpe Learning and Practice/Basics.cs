using System;

namespace CSharpe_Learning_and_Practice
{
    /// <summary>
    /// 
    /// </summary>
    public class Basics
    {
        //some variables

        int num = 10;
        //multiple
        double num1 = 10.09, num2 = 12.0, num3 = 18;
        //multiline
        float
            nums1,
            nums2,
            nums3;
        string name = "Yash Dengre"
            + "and this is basics of .net and C#";

        //DataTypes
        //There are two types of dataypes in C# = >
        //Value type and reference type  and pointer types (mostly pointer and reference type are considered as same)
        //Values Types are
        //Predefined and user defined both
        //like
        int a;
        float b;
        bool c;
        //user defined are
        enum AA { };
        struct BB { };

        //Reference Types are
        object objectType;
        dynamic variable;

        //delegate type;
        //and also user defined like=? Classes, Interfaces, etc.

        //pointer type
        // => this is need to be check again.

        //pointer will only be applicable in unsafe block

        public unsafe void PointerExample()
        {
            //unsafe { }
            int val = 10;
            int* addVal = &val;
            Console.WriteLine($"Adderes of Val : {(int)addVal} " +
                $"{Environment.NewLine} Val : {val}" +
                $"{Environment.NewLine} Now accessing the value at adderes :  { addVal->ToString()}");
        }

        //implictly and explicitly conversion

        int k = 10; // (implictly conversion)
        void useVarKeyword()
        {
            var variable = 10; //implictly conversion
            double kk = (double)k;    //explictly
            string stringCOnversion = Convert.ToString(kk); //explictly
        }

        //Keywords=> many of the words are already reserved in C# -> called  Keywords;
        //Operators => workds on the priority and precedence;

        void ValueType_RefernceType()
        {
            int i = 10; //value type

        }
        //pass by value and pass by reference

        public int passByValue = 100;
        public void PassByValue(int a)
        {
            a = a + 10;
            Console.WriteLine("Pass by value A : " + a);
        }
        public void PassByRef(ref int data)
        {
            data = data + 10;
            Console.WriteLine("pass by ref A : " + data);
        }
        // Also if you pass classes and object it automatically take it as ref





    }
}
