using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpe_Learning_and_Practice.OtherBasics
{
    public class Experiment
    {
        static int AddOptioanl(int value1 = 10, int value2 = 10)
        {
            return value1 + value2;
        }
        //static int AddOptionalDef(int value = 100, int val) //optional parameter should come after required parameter
        //{
        //    return value + val;
        //}
        public string ConstructorName;
        static int NamedMultiply(int Value, int SecondValue)
        {
            return Value * SecondValue;
        }
        //Exression Bodied Members
        //Method
        public static string DataShow() => "Data Show method by Expression Bodied";
        //properties
        public static string DataProperty => "Data Property 1 by Expression Bodied";
        public static string DataProperty2 { get => "Data Property 2 by Expression Bodied"; }
        //Contrusctor and Desctructor(Finalizer)
        //Constructor
        public Experiment(string name) => ConstructorName = name;
        //Finalizer
        ~Experiment() => Console.WriteLine("finalizer called!");
        //Getter Setter Properties
        public string GetterSetterByExpressionBodied
        {
            get => ConstructorName;
            set => ConstructorName = value;
        }



        public static void Main10()
        {

            System.Console.WriteLine("Add Optional Param but passed " + AddOptioanl(123, 22));
            System.Console.WriteLine("Add Optional Param but not passed " + AddOptioanl());
            System.Console.WriteLine("Add Optional Param but only one passed " + AddOptioanl(291));
            System.Console.WriteLine("Named Multiply Param " + NamedMultiply(SecondValue: 212, Value: 18));// we can change the order
            System.Console.ReadKey();

            //Digit Separator in C# 7.0    : to make value readable
            int i = 1_00_000;
            double J = 1_00_000;

            //We C# 7.0 Introduced Binary and hexadecimal literals
            int binary = 0b1010;
            int hexa = 0x00A;
            System.Console.WriteLine($"Binary value of : int binary = 0b10101: {binary}");
            System.Console.WriteLine($"Hexadecimal value of : int hexa = 0x00A: {hexa}");

            //we can also use digit separator with binary literals
            int a = 0b1_01_0;
            // Separating hexadecimal literals  
            int b = 0x00_A;
            System.Console.WriteLine($"Binary value of : int a = 0b1_01_0: {a}");
            System.Console.WriteLine($"Hexadecimal value of : int b = 0x00_A: {b}");
            Console.WriteLine(DataProperty + "\n" + DataProperty2 + $"\n");
            Console.WriteLine(DataShow());
            //Caller Info Attribute
            CallInfoTestMethod();
            try
            {
                //Exception Filter
                int[] Temp = new int[10];
                Temp[20] = 10;
            }
            catch (Exception e) when (e.GetType().ToString().Equals("IndexOutOfRangeException"))
            {

                Console.WriteLine("Exception is captured in First catch");
            }
            catch (Exception e) when (e.GetType().ToString().Equals("System.IndexOutOfRangeException"))
            {
                Console.WriteLine("Exception is captured in Second catch");
            }

            //Await in  catch and finally block
            CatchFinallyAwaitExp();

            Expression defaultExpression = Expression.Default(typeof(Experiment));
            show(defaultExpression);

            System.Console.ReadKey();


        }

        public static void CallInfoTestMethod([CallerMemberName] string callerName = null, [CallerLineNumber] int lineNum = -1, [CallerFilePath] string callerFilePath = null)
        {
            Console.WriteLine("FIle Path " + callerFilePath);
            Console.WriteLine("Caller Method Name " + callerName + " and Line Number " + lineNum);
        }

        public async static Task CatchFinallyAwaitExp()
        {
            try
            {
                //Exception Filter
                int[] Temp = new int[10];
                Temp[20] = 10;
            }
            catch
            {
                //
                awaitCatch();
                Console.WriteLine("Print anything in catch");
            }
            finally
            {
                await awaitFinally();      //untill this function is not completed the control will not move further from here
                Console.WriteLine("Print anything in finally");

            }
        }
        public async static Task awaitCatch()
        {
            await Task.Run(() =>
            {
                //for (int i = 0; i <= 1000; i++)
                //{ Console.WriteLine(i); }
                Thread.Sleep(1200);
            });

            Console.WriteLine("In await mode for catch");

        }
        public async static Task awaitFinally()
        {
            await Task.Run(() => { Console.WriteLine("In await mode for finally"); });

        }
        //Default Expression
        static void show(Expression defaultExpression)
        {
            // Default expression properties and methods  
            Console.WriteLine("\n\nInstace:       " + defaultExpression);
            Console.WriteLine("Type:          " + defaultExpression.Type);
            Console.WriteLine("Can reduce:    " + defaultExpression.CanReduce);
            Console.WriteLine("Instance type: " + defaultExpression.GetType());
            Console.WriteLine("Node type:     " + defaultExpression.NodeType);
        }


    }
}
