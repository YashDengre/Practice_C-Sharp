using System;
using System.Collections.Generic;

namespace SimpleGenerics
{
    //we can declare delegates any where 
    delegate T GenericDelegateNumberChage<T>(T number);
    /// <summary>
    /// 
    /// </summary>
    public class Generics<TKey, TValue>
    {

        public TKey Key { get; set; }
        public TValue Value { get; set; }

        public Dictionary<TKey, TValue> Items { get; set; }



    }

    public class GenricsMethod
    {
        public void ShowMessage<T>(T Message, T Description)
        {
            Console.WriteLine($"Message : {Message} {Environment.NewLine} Description : {Description}");

        }
    }

    public class Nullable<T>
    {
        private object _value;
        public Nullable()
        {

        }

        public Nullable(T value)
        {
            _value = value;
        }
        public bool IsNull
        {
            get { return _value == null; }
        }
        public T GetValueORDefault()
        {
            if (IsNull)
                return default(T);
            return (T)_value;
        }
    }

    public class GenerericDelegate
    {
        public int NumberCH(int number)
        {
            number += 10;
            return number;
        }

        public float NumberCHF(float number)
        {
            number += 10;
            return number;
        }
        public void Calling()
        {
            GenericDelegateNumberChage<int> NumberChange = new GenericDelegateNumberChage<int>(NumberCH);
            Console.WriteLine("Number is chanegd + " + NumberChange(10));
            GenericDelegateNumberChage<float> NumberChangeF = new GenericDelegateNumberChage<float>(NumberCHF);
            Console.WriteLine("Number is chanegd + " + NumberChangeF(120));


            //anonymous methods /fucntions
            //two types:
            //Lambda Expressions and methods it self
            //it has to use with delegates only
            GenericDelegateNumberChage<int> ALambda = x => x * x;
            Console.WriteLine("Anonymous Lambda Expression:" + ALambda(10));
            GenericDelegateNumberChage<int> AMethod = delegate (int data) { return data * 10; };
            Console.WriteLine("Anonymous Method :" + AMethod(100));


        }
    }



    // we use where to add constraints :
    /*
     * Where T : IComparable
     * Where T : Generics (Custom Class Name)
     * Where T : struct (value type)
     * where T : class (ref type)
     * where T : new() (default constructor)
     */
}
