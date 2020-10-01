using System;
using System.Threading;

namespace CSharpe_Learning_and_Practice.Delegates_and_Events
{
    public delegate void CallBackPointer(int i);

    public class DelegateCallBack
    {
        public static void CallBackCatcher(int i)
        {
            System.Console.WriteLine(i);
        }
    }
    public class SomeBigWork
    {
        public void BigWork(CallBackPointer CallDelegate)
        {
            for (int i = 0; i < 1000; i++)
            {
                CallDelegate(i);
            }
        }
    }

    public delegate string PointerToBigTask();

    public class DelegateCallBackAsynchronous
    {
        public string BigTask()
        {
            Thread.Sleep(10000);
            return "Task is Completed at" + DateTime.Now.TimeOfDay.ToString();
        }

        public void CallBackMethod(IAsyncResult result)
        {
            PointerToBigTask pointerToBigTask = (PointerToBigTask)result.AsyncState;
            string messageRetrun = pointerToBigTask.EndInvoke(result);
            Console.WriteLine("Message Returned after Big Task finished - Asynchronously : " + messageRetrun);

        }
    }

}
