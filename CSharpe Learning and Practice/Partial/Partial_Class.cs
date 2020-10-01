namespace CSharpe_Learning_and_Practice.Partial
{
    public partial class PartialClass
    {

        partial void Method_One(int num)
        {
            System.Console.WriteLine("Part1 of Method one");
        }


        public PartialClass(string name)
        {
            this.Name = name;
        }
        public void GoodBye()
        {
            System.Console.WriteLine("GoodBye");
        }
    }

}
