using SimpleGenerics;
using System;
using System.Threading;

namespace CSharpe_Learning_and_Practice
{
    /// <summary>
    /// 
    /// </summary>
    public class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public static void Main1(string[] args)
        {
            Console.WriteLine("This is Main Method");

            //command line arguements

            int countArg = 0;
            foreach (var data in args)
            {
                Console.WriteLine($"Command Line Argument {countArg} : {data}");
                countArg = countArg + 1;
            }
            Console.WriteLine($"{Environment.NewLine }");

            //Code for practice
            //Basics
            Basics basic = new Basics();
            Console.WriteLine("Pass By Value:" + basic.passByValue);
            basic.PassByValue(basic.passByValue);
            Console.WriteLine("After Pass By Value:" + basic.passByValue);

            basic.PassByRef(ref basic.passByValue);
            Console.WriteLine("After Pass By ref:" + basic.passByValue);

            //Intermediate
            Intermediate intermediate = new Intermediate();

            intermediate.NormalMethod();
            var count = intermediate.RecursiveMethod(6);
            Console.WriteLine("Recursive method sum:" + count);


            //Generics Class
            //Check any value is null of. if not then get thevalue
            SimpleGenerics.Nullable<int> nullValue = new SimpleGenerics.Nullable<int>(12);
            var value = nullValue.IsNull == false ? nullValue.GetValueORDefault() : 0;



            //Interfaces, Sealed class, Abstract class and Inheritance

            AbstractDerived AD = new AbstractDerived("DexJar Corporation");
            AD.ShowCustomMessage();
            AD.ShowCustomMessage("DexJar Corporation");
            AD.ShowCustomMessage("DexJar Corporation", "Is a upcoming  brand");
            AD.ShowMethod();

            //sealed class
            SealedCLass SC = new SealedCLass();
            SC.showMessage();

            ITryOutInterface tryOut = new TryOutInterface();
            var tryOutMsg = tryOut.ReturnWelcomeMessage("Yash Dengre");

            First _first = new First();
            Console.WriteLine(_first.Hello());
            _first = new Second();
            Console.WriteLine(_first.Hello());
            _first = new Third();
            Console.WriteLine(_first.Hello());


            //trying the CustomException
            try
            {
                if (5 != 9)
                {
                    throw new TryExepction.UserException("Sample Test");
                }
            }
            catch (TryExepction.UserException ex)
            {
                Console.WriteLine(ex.Message + "Stack Trace" + ex.StackTrace);
            }

            //Checked and Unchecked

            // it checks the overflow of the data type
            //example for int we can see the below example
            {
                int val = int.MaxValue;
                Console.WriteLine("Int Max Value : " + val);
                Console.WriteLine("Int Max Value  + 2 {this is wrong value}: " + (val + 2));
                Console.WriteLine("We can put check to validate this");
                try
                {
                    checked
                    {
                        Console.WriteLine("Int Max Value  + 2 {this is wrong value : Inside the checked}: " + (val + 2));

                    }
                    //and uncheck will work same as  we dont use check 
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }


            }



            //IO Operations
            IOClass _io = new IOClass();
            _io.ReadWriteFileStream();
            _io.StreamWriteF();
            _io.StreamReaderF();
            _io.TextWriterF();
            _io.TextReaderF();
            _io.BinaryWriterF();
            _io.BinaryReaderF();
            _io.StringWriterF();
            _io.StringReaderF();
            _io.FIleInfoCreateF();
            _io.FIleInfoWriteF();
            _io.FIleInfoReadF();
            _io.FIleInfoDeleteF();
            _io.DirectoryInfoF();
            _io.DirectoryInfoF();

            //serialize and Deserialize
            Serialize_Deserialize SD = new Serialize_Deserialize();
            SD.SerializeAndWrite();
            SD.DeserializeAndRead();

            //Collections
            CustomCollection CC = new CustomCollection();
            CC.AddDataToCollections();
            CC.ViewCollecitonsInfo();

            //Generic Delegates

            GenerericDelegate GD = new GenerericDelegate();
            GD.Calling();


            Thread.Sleep(1000);
            Console.Clear();
            //Video Encoder - Events and Delegates
            var video = new CustomEventsAndDelegates.Video()
            {
                Title = "DexJar-  The Ultimate Journey",
                Video_Quality = "720p",
                Length = new TimeSpan(0, 7, 70)
            };
            var videoEncoder = new CustomEventsAndDelegates.VideoEncoder();  //publisher
            var mailServer = new CustomEventsAndDelegates.MailService(); //subscriber
            var messageServer = new CustomEventsAndDelegates.MessageService();
            videoEncoder.VideoEncoded += mailServer.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageServer.OnVideoEncoded;

            videoEncoder.Encode(video);

            //Delegate with Call Back : for Asynchronous call and parallel work

            Delegates_and_Events.SomeBigWork work = new Delegates_and_Events.SomeBigWork();
            work.BigWork(Delegates_and_Events.DelegateCallBack.CallBackCatcher);

            //Delegates with call abck method for asynchronous call
            Delegates_and_Events.DelegateCallBackAsynchronous DelAsync = new Delegates_and_Events.DelegateCallBackAsynchronous();
            Delegates_and_Events.PointerToBigTask pointerToBigTask = new Delegates_and_Events.PointerToBigTask(DelAsync.BigTask);
            //call the delegate asynchronously
            pointerToBigTask.BeginInvoke(new AsyncCallback(DelAsync.CallBackMethod), pointerToBigTask);

            Console.Clear();
            //Regular Expression

            RegularExpression Regx = new RegularExpression();
            var isValid_Email = Regx.ValidateRegEx(Validate.EMAIL, "yash.dengre68@gmail.com");
            var isValidMobile = Regx.ValidateRegEx(Validate.MOBILE, "+91-8109729582");
            Console.WriteLine(Regx.ValidateRegEx(Validate.EMAIL, "yashdengre68@gmail.com"));
            Console.WriteLine(Regx.ValidateRegEx(Validate.EMAIL, "yash12dengre68@gmail.com"));
            Console.WriteLine(Regx.ValidateRegEx(Validate.EMAIL, "yashdengre68@ymail.com"));





            Console.WriteLine("Asynchronous call is being made.");
            Console.WriteLine("Enter any key to continue;");
            Console.ReadKey();

        }
    }
}
