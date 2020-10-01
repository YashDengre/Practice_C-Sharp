using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpe_Learning_and_Practice.AsynchronousProgramming
{
    class AsynchronousOperations
    {
        //public static void MainTemp()//remove Temp if need to use this
        //{
        //    Task<int> TaskLength = ReturnLength();
        //    System.Console.WriteLine("So as we can see this line is printed, even the ReturnLength is still in progress");

        //    var result = TaskLength.Result;    //when control here it will go abck to the function where it is executing and bring back the result
        //    var resultNew = TaskLength;
        //    System.Console.WriteLine("Length : " + result + " and " + resultNew);
        //    System.Console.ReadKey();

        //}

        public async static Task<int> Main10(string[] arges)
        {
            Task<int> TaskResult = ReturnLength();
            var result = await TaskResult;  // it will stop the further execution and send the control back
            //if we remove the await then temp will be printed
            System.Console.WriteLine("Temp");
            System.Console.WriteLine("Result : " + result);
            System.Console.ReadKey();
            return 0;
        }
        public async static Task<int> ReturnLength()
        {

            Task<string> TaskUrl = new HttpClient().GetStringAsync(@"https://www.google.com");
            string res = await TaskUrl;
            Thread.Sleep(5000);
            var data = TaskUrl.Result;
            //System.Console.WriteLine("Data:" + data);
            return res.Length;
        }
    }


}
