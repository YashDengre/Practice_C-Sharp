namespace CSharpe_Learning_and_Practice.Partial
{
    // it can be sealed too
    //public sealed partial class PartialClass
    //{
    //}
    public partial class PartialClass
    {
        public PartialClass()
        {
            this.Name = "Default";
        }
        public string Name { get; set; }
        partial void Method_One(int num);
        partial void Method_two(int num);
        public void welcome(string message)
        {
            System.Console.WriteLine("Welcome : " + message);
        }


    }
}
