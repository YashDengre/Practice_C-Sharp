#define DEBUG 
using System;

namespace CSharpe_Learning_and_Practice
{
    public class Intermediate
    {
        //Encapsulation and classes object
        //combining these members and methods into one class and then classes into namespaces are called Encapsulations

        public Intermediate()
        {
            Console.WriteLine($"This is Intermediate class: {Environment.NewLine}" +
                $"Definition Encapsulation: Combining these members and methods into one class and then classes into namespaces are called Encapsulations" +
                $" ");

        }

        //Access Specifiers are :  defines the scope and visibility of the class members;
        //public, private, protected, internal, protected internal

        //Methods
        //Normal Method
        public void NormalMethod()
        {
            Console.WriteLine("This is normal methods");
        }
        public int RecursiveMethod(int a)
        {
            if (a == 0)
            {
                return 0;
            }
            else if (a == 1)
            {
                return 1;
            }
            else
            {
                a = a - 1;
                return (a + RecursiveMethod(a));
            }
        }
        //out parameter
        public int OutParam;
        public void RetrunOutSum(int a, int b, out int sum)
        {
            sum = a + b;
        }
        //ref vs out:
        //ref must be initilize before passing
        //out must be assign only , initialization is not required

        //Nullable
        //nullable created by MS so that we can hold the null value in value type variable
        //int nullNotAllowed = null;  //will give error
        int? nullAllowed = null;    //Implements nullable class = ?
        Nullable<int> intV = new Nullable<int>();

        void NullableType()
        {
            int a = nullAllowed ?? 10; //if nullAllowed is null then 10 will be assign
        }
        dynamic value;
        //it skip the compile time binding(early or static binding ) and type will be check at run time

        //C# Anonymous Type

        void AnonymousType()
        {
            var AnonymousType = new
            {
                FName = "Yash",
                LName = "Dengre",
                Education = new
                {
                    College = "ITM University",
                    Course = "B.tech",
                    Percentage = 82.0
                }
            };

            Console.WriteLine();
        }

        protected void ArrayFunction()
        {
            int[] arr = new int[5] { 10, 2, 4, 5, 6 };
            int[] arr2 = new int[] { 1, 2, 4 };

            //multidimensional array
            int[,] twoD = new int[2, 2];
            int[,] twDD = new int[2, 2] { { 1, 2 }, { 2, 3 } };
            int[,,] threeD = new int[2, 2, 2] { { { 1, 2 }, { 1, 2 } }, { { 1, 2 }, { 1, 2 } } };
            //Jagged Array
            int[][] JaggedArray = new int[2][] { new int[] { 1, 2, 3, 4, 5 }, new int[] { 2, 34 } };
            //Params are used to hold the any number of argument pass in function
            // and after params nothing is allowed

            // Array Class by C#
            //This is given by MS for reducing the efforts that developer put in managing the array
            //there are many methods and properties which really helps us to manage the array
            //it is the base class for all the arrays - not collection but considered as collection as it is derivded from the collection class
            Array.Sort(arr);
            Array.IndexOf(arr, 2);
            //these above methods are basic methods
            var isFixed = arr.IsFixedSize;

            //command line argument
            //see the program class and execute by command prompt;



        }

        void ParamArry(int num, params int[] values)
        {
            //we can traverse the values for particular operations
        }


    }

    public class Parent
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = string.IsNullOrEmpty(value) ? "Empty / Null Value" : value;
            }
        }

        public void Print()
        {
            Console.WriteLine("Parent class : " + Name);
        }
        //override
        public virtual void ShowMethod(dynamic output)
        {
            Console.WriteLine("Show Method in Parent : " + output);
        }
    }
    public class Child : Parent
    {
        public override void ShowMethod(dynamic output)
        {
            Console.WriteLine("Show Method in Child : " + output);
        }
    }

    public abstract class ParentAbstract
    {
        public abstract void ShowMethod();
        public void NormalMethod(dynamic value)
        {
            {
                Console.WriteLine("Parent Abstract class : " + value);
            }
        }
        public abstract string PropertyName { get; set; }

    }

    public class AbstractDerived : ParentAbstract
    {
        public dynamic TValue;

        public override string PropertyName
        {
            get; set;
        }

        public AbstractDerived(dynamic value)
        {
            TValue = value;
        }
        public override void ShowMethod()
        {
            Console.WriteLine(" Derived class of ABstract Parent");
            NormalMethod(this.TValue);
        }
        //overloading
        public void ShowCustomMessage()
        {
            Console.WriteLine("Custom Message 1 : This is function overloading method 1 ");

        }
        public void ShowCustomMessage(string message)
        {
            Console.WriteLine("Custom Message 2 : This is function overloading method 2 " + message);

        }
        public string ShowCustomMessage(string message, string description)
        {
            Console.WriteLine($"Custom Message 3 : This is function overloading method 3 {Environment.NewLine}" +
                $"Message : {message} \n Description : {description}");
            return "";

        }
    }

    public sealed class SealedCLass
    {
        //cannot inherit this at any cost
        public void showMessage()
        {
            Console.WriteLine("This is sealed class and you can not inherit this");

        }
    }

    public interface ITryOutInterface
    {
        //everything is abstact here 
        //you need to define all the declaration in the dervied class
        string ReturnWelcomeMessage(string Name);
    }
    public class TryOutInterface : ITryOutInterface
    {
        public string ReturnWelcomeMessage(string Name)
        {
            return $"Hello {Name}, your most welcome to our Company!";
        }
    }


    public class First
    {
        public virtual string Hello()
        {
            return "Hello";
        }
    }
    public class Second : First
    {
        public string Welcome()
        {
            return "Welcome";
        }
        public override string Hello()
        {
            return "Hello Second";
        }
    }
    public class Third : Second
    {
        public string Bye()
        {
            return "Bye!";
        }
        public override string Hello()
        {
            return base.Hello();
        }
    }
}

namespace TryExepction
{
    public class UserException : Exception
    {
        public UserException(string message) : base(message)
        {

        }
    }
}

