using System;
using System.Threading;

namespace CSharpe_Learning_and_Practice.MultiThreading
{
    public class MultiThreading
    {

        public static void Main8(string[] args)
        {
            //Main Thread
            Thread th = Thread.CurrentThread;
            Console.WriteLine($"Current Thread Name Before : {th.Name}");
            th.Name = "Main Thread";
            Console.WriteLine($"Current Thread Name After : {th.Name}");

            //Sample Thread  :  Create
            Thread T1 = new Thread(new ThreadStart(ThreadOperations.MethodForExecution));
            ThreadStart ThreadRef = new ThreadStart(ThreadOperations.MethodForExecution);
            Thread T2 = new Thread(ThreadRef);
            //Output will be unpredictable
            T1.Start();
            T2.Start();
            Thread.Sleep(1000);
            Console.Clear();
            ThreadOperations TO = new ThreadOperations();
            Thread T3 = new Thread(new ThreadStart(ThreadOperations.MethodForExecution));
            Thread T4 = new Thread(TO.AnotherMethodForExe);
            T3.Start();
            T4.Start(8);
            //Managing Thread
            //Sleep
            Thread T5 = new Thread(new ThreadStart(ThreadOperations.MethodManageThread));
            Thread T6 = new Thread(new ThreadStart(ThreadOperations.MethodManageThread));
            T5.Name = "Thread 5";
            T6.Name = "Thread 6";

            Console.Clear();
            T5.Start();
            T6.Start();
            //Abort
            //while aborting it raises the ThreadAbortException - it might be caught and might not

            Thread T7 = new Thread(new ThreadStart(ThreadOperations.MethodManageThread));
            Thread T8 = new Thread(new ThreadStart(ThreadOperations.MethodManageThread));
            T7.Name = "Thread 7";
            T8.Name = "Thread 8";

            try
            {
                T7.Start();
                T8.Start();
                T7.Abort();
                T8.Abort();
            }
            catch (ThreadAbortException TAE)
            {
                Console.WriteLine("In Catch Block -  Abort Exception Catched");
            }
            finally
            {
                Console.WriteLine("In Finally Block -  After Exception ");
            }
            //join
            //will execute the current thread untill it completes and will half the other thread for executions

            Thread.Sleep(1000);
            Thread T9 = new Thread(new ThreadStart(ThreadOperations.MethodManageThread));
            Thread T10 = new Thread(new ThreadStart(ThreadOperations.MethodManageThread));
            Thread T11 = new Thread(new ThreadStart(ThreadOperations.MethodManageThread));
            T9.Name = "Thread 9";
            T10.Name = "Thread 10";
            T11.Name = "Thread 11";
            //Priority
            T9.Priority = ThreadPriority.Highest;
            T10.Priority = ThreadPriority.Normal;
            T11.Priority = ThreadPriority.Lowest;


            T9.Start();
            T9.Join();
            T10.Start();
            T11.Start();


            //temp - abort previous thread
            try { T10.Abort(); T11.Abort(); }
            catch (Exception e)
            { }
            finally { }
            Thread T12 = new Thread(new ThreadStart(TO.MethodForSync));
            Thread T13 = new Thread(new ThreadStart(TO.MethodForSync));
            Thread T14 = new Thread(new ThreadStart(TO.MethodForSync));
            T12.Name = "Thread 12";
            T13.Name = "Thread 13";
            T14.Name = "Thread 14";

            T12.Start();
            T13.Start();
            T14.Start();

            Console.ReadKey();
        }
    }

    public class ThreadOperations
    {
        public static void MethodForExecution()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("i : " + i);
            }
        }

        public void AnotherMethodForExe(object size)
        {
            for (int i = 0; i < (int)size; i++)
            {
                Console.WriteLine("i : " + i);
            }
        }

        public static void MethodManageThread()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Thread Name : {Thread.CurrentThread.Name}: i : " + i);
                Thread.Sleep(100);
            }
        }

        public void MethodForSync()
        {
            lock (this)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Thread Name : {Thread.CurrentThread.Name}: i : " + i);
                    Thread.Sleep(100);
                }
            }
        }
    }
}
