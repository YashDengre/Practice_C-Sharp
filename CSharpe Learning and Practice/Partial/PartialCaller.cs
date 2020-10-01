using System;

namespace CSharpe_Learning_and_Practice.Partial
{
    public class PartialCaller
    {
        public PartialClass PC;


        public static void Main5(string[] args)
        {
            PartialClass pcc = new PartialClass();
            pcc.welcome("Hello");
            PartialCaller partialcaller = new PartialCaller();
            partialcaller.PC = new PartialClass("Yash");
            partialcaller.PC.GoodBye();
            Console.ReadKey();
        }

    }
}
