using System;

namespace CSharpe_Learning_and_Practice.Func_Action_Predicate_ExtensionMethods
{
    public class Executer
    {
        public static int MethodForFunc(int val, int data)
        {
            return val + data;
        }
        public static string MethodForFunc(string Name, string company, int index)
        {
            return $"Welcome to our Company Mr./Mrs./Ms. {Name}, we know about your company {company} and " +
                $"we also know that your company is at rank " +
                $" {index} in global market";
        }
        //public static string Return { get; set; }
        public static void MethodForFAction(string name, string message)
        {
            Console.WriteLine($"Welcome to Our Company " + name + "And we appreciate your message : " + message);

        }

        public static bool MethodForPredicate_IsUpper(string Value)
        {
            return Value.Equals(Value.Trim().ToUpper());
        }
        public static bool MethodForPredicate_IsLowerr(string Value)
        {
            return Value.Equals(Value.Trim().ToLower());
        }

        public static void Main7(string[] args)
        {
            //Func
            //these are the built in Predefined Delegates use to reduce the work that developers do for creating custom delegates
            //It has returns type and parameters to perform the operations

            Func<int, int, int> FuncMethod = MethodForFunc;
            //another way to initialize the Func delegate 
            Func<string, string, int, string> FunMethod2 = new Func<string, string, int, string>(MethodForFunc);
            Console.WriteLine("FuncMethod 1 return:" + FuncMethod(10, 100));
            Console.WriteLine("FuncMethod 1 return:" + FunMethod2("Yash Dengre", "DexJar", 3));
            //Anonymous Method
            Func<int> AnonyFuncRandom = delegate ()
            {
                Random random = new Random();

                return random.Next(200, 2123321);
            };
            Console.WriteLine($"Anonymous Method Random Number: " + AnonyFuncRandom());

            //Lambda Expression
            Func<int> getRandomNumber = () => new Random().Next(1, 100);
            //Or 
            Func<int, int, int> Sum = (x, y) => x + y;
            Console.WriteLine($"Lambda Expression Method Random Number: " + getRandomNumber());
            Console.WriteLine($"Lambda Expression Method Sum : " + Sum(200, 31312));
            //Action 
            //These are also the built in predefined Delegegates like  Func 
            //But it does not return any thing and use for the method which have to perform operation and dont need to  return anything
            Action<string, string> ActionMethod = MethodForFAction;
            ActionMethod("Yash", "Thank You for having me here!");

            //Lambda Expression and Anonymous Function
            Action<int> PrintAge = (int i) => { Console.WriteLine("Age:" + i); };

            PrintAge(24);
            Action<int> printActionDel = i => Console.WriteLine("Temporary Action  : " + i);

            printActionDel(10);
            Action<int> printActionDelMethod = delegate (int i)
            {
                Console.WriteLine("printActionDelMethod : " + i);
            };
            printActionDelMethod(10);


            //Predicate Delegate
            //These are same as Func and Action
            //Only Difference is they are use to perform some condition and take only on argument and return the boolean value


            Predicate<string> PredicateFunctionUpper = MethodForPredicate_IsUpper;
            Predicate<string> PredicateFunctionLower = new Predicate<string>(MethodForPredicate_IsLowerr);

            Console.WriteLine("Yash is in Upper case ? : " + PredicateFunctionUpper("Yash"));
            Console.WriteLine("yash is in Upper case ? : " + PredicateFunctionLower("yash"));

            //Anonymous method and lambda expression
            Predicate<int> PredicateIsLessThanEqualIntHundred = (int val) => { return val <= 100; };
            Console.WriteLine("87 is in Less than or equal to 100 ? : " + PredicateIsLessThanEqualIntHundred(87));
            Predicate<string> PredicateLambdaIsUpper = s => { return s.Equals(s.ToUpper()); };
            Console.WriteLine("DEXJAR is in Upper case ? : " + PredicateLambdaIsUpper("DEXJAR") + ", Checked By Lambda Expression");


            //Extension Method


            int tempIntValue = 90;
            string tempStringValue = "DexJar";
            Console.WriteLine("Checking whether 90 is greater than 78 by extension method : " + tempIntValue.IsGreaterThan(78));

            Console.WriteLine($"DexJar =  Converting into Upper case by Extension Method : " + tempStringValue.ToUpperEx());

            Console.ReadKey();


        }
    }

    public static class Extension
    {
        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }
        public static string ToUpperEx(this string value)
        {
            return value.Trim().ToUpper();
        }
    }
}
