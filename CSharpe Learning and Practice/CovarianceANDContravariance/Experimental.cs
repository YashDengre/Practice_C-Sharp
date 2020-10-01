using System;

namespace CSharpe_Learning_and_Practice.CovarianceANDContravariance
{
    public class Experimental
    {
        //created delegate 
        public delegate Small CovarDel(Bigger biggerOb);
        //now we will create some function which will allows us to use base object from derived ones

        public static Bigger MethodBigger(Bigger biggerOb)
        {
            Console.WriteLine("MethodBigger");
            return new Bigger();
        }
        public static Big MethodBig(Bigger biggerOb)
        {
            Console.WriteLine("MethodBig");
            return new Big();
        }
        public static Small MethodSmall(Small SmallOb)
        {
            Console.WriteLine("MethodSmall");
            return new Small();
        }

        public static void Main9(string[] args)
        {
            Small small1 = new Small();
            Small small2 = new Big();
            Small small3 = new Bigger();
            Big big1 = new Big();
            Big big2 = new Bigger();
            //Big Big3 = new Small();  // Not allowed
            Bigger bigger1 = new Bigger();
            //Bigger bigger2 = new Big();  // not allowed
            //The reason is instance can accept big funcitionality if the need is still small
            //but instances can not accept the small need if the need is big
            //So in order to serve these kind of funtionality we use covariance in C#
            //we will create delegate
            CovarDel delegateOb = MethodBigger;
            Small small4 = delegateOb(new Bigger());
            CovarDel delegateOb1 = MethodSmall;  //delegate expecting the Bigger right now but we ave proided the method small
            delegateOb1(new Bigger());

        }
    }

    public class Small
    {
        public void MethodSmall()
        {
            Console.WriteLine("Method in small class");
        }
    }

    public class Big : Small
    {
        public void MethodBig()
        {
            Console.WriteLine("Method in Big class");
        }
    }
    public class Bigger : Big
    {
        public void MethodBigger()
        {
            Console.WriteLine("Method in Bigger class");
        }
    }
}
