using System;

namespace CSharpe_Learning_and_Practice.Tuples
{
    public class CustomTuple
    {
        //Tuple can have max 8 members and tuple is Generice type so any type u can assiggn 
        public static void Tuples()
        {
            Tuple<int, string, long> Person = new Tuple<int, string, long>(1, "Yash Dengre", 25000);
            //and for storing more data you can use nested tuples
            Tuple<int, string, Tuple<int, string, int>> AnotherPerson = new Tuple<int, string, Tuple<int, string, int>>(1, "Dexjar", new Tuple<int, string, int>(123, "Grabar", 2));
            var TupleBYVar = Tuple.Create(1, 2, 3, 4, "Yash", "Dengre", "TCS", Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(1, "End"))));
            var TupleByVarAnother = new Tuple<int, int, string>(1, 2, "Yash Dengre");

            Console.WriteLine($"Tuple By Var :");
            Console.WriteLine($"Item1 : {TupleBYVar.Item1}");
            Console.WriteLine($"Item2 : {TupleBYVar.Item2}");
            Console.WriteLine($"Item3 : {TupleBYVar.Item3}");
            Console.WriteLine($"Item4 : {TupleBYVar.Item4}");
            Console.WriteLine($"Item5 : {TupleBYVar.Item5}");
            Console.WriteLine($"Item6 : {TupleBYVar.Item6}");
            Console.WriteLine($"Item7 : {TupleBYVar.Item7}");
            Console.WriteLine($"Item8 or Rest : {TupleBYVar.Rest}");
            Console.WriteLine($"Item8 or Rest : item1: {TupleBYVar.Rest.Item1}");
            Console.WriteLine($"Item8 or Rest : item1 : item 1: {TupleBYVar.Rest.Item1.Item1}");
            Console.WriteLine($"Item8 or Rest : item1 : item 2: {TupleBYVar.Rest.Item1.Item2}");
            Console.WriteLine($"Item8 or Rest : item1 : item 3: {TupleBYVar.Rest.Item1.Item3}");
            Console.WriteLine($"Item8 or Rest : item1 : item 4: {TupleBYVar.Rest.Item1.Item4}");
            Console.WriteLine($"Item8 or Rest : item1 : item 5: {TupleBYVar.Rest.Item1.Item5}");
            Console.WriteLine($"Item8 or Rest : item1 : item 6: {TupleBYVar.Rest.Item1.Item6}");
            Console.WriteLine($"Item8 or Rest : item1 : item 7: {TupleBYVar.Rest.Item1.Item7}");
            Console.WriteLine($"Item8 or Rest : item1 : Rest or item 8: {TupleBYVar.Rest.Item1.Rest}");
            Console.WriteLine($"Item8 or Rest : item1 : Rest or item 8 : Item1: {TupleBYVar.Rest.Item1.Rest.Item1}");
            Console.WriteLine($"Item8 or Rest : item1 : Rest or item 8 : Item1 : item 1: {TupleBYVar.Rest.Item1.Rest.Item1.Item1}");
            Console.WriteLine($"Item8 or Rest : item1 : Rest or item 8 : Item1 : item 2: {TupleBYVar.Rest.Item1.Rest.Item1.Item2}");
            Console.WriteLine($"Item8 or Rest : item1 : Rest or item 8 : Item1 : item 3: {TupleBYVar.Rest.Item1.Rest.Item1.Item3}");
            Console.WriteLine($"Item8 or Rest : item1 : Rest or item 8 : Item1 : item 4: {TupleBYVar.Rest.Item1.Rest.Item1.Item4}");
            Console.WriteLine($"Item8 or Rest : item1 : Rest or item 8 : Item1 : item 5: {TupleBYVar.Rest.Item1.Rest.Item1.Item5}");
            Console.WriteLine($"Item8 or Rest : item1 : Rest or item 8 : Item1 : item 6: {TupleBYVar.Rest.Item1.Rest.Item1.Item6}");
            Console.WriteLine($"Item8 or Rest : item1 : Rest or item 8 : Item1 : item 7: {TupleBYVar.Rest.Item1.Rest.Item1.Item7}");
            Console.WriteLine($"Item8 or Rest : item1 : Rest or item 8 : Item1 : item 8 or Rest: {TupleBYVar.Rest.Item1.Rest.Item1.Rest}");
            Console.WriteLine($"Item8 or Rest : item1 : Rest or item 8 : Item1 : item 8 or Rest :  item1: {TupleBYVar.Rest.Item1.Rest.Item1.Rest.Item1}");
            Console.WriteLine($"Item8 or Rest : item1 : Rest or item 8 : Item1 : item 8 or Rest :  item1 : item 1: {TupleBYVar.Rest.Item1.Rest.Item1.Rest.Item1.Item1}");
            Console.WriteLine($"Item8 or Rest : item1 : Rest or item 8 : Item1 : item 8 or Rest :  item1 : item 2: {TupleBYVar.Rest.Item1.Rest.Item1.Rest.Item1.Item2}");



        }

        public static void TupleAsParameter(Tuple<int, string> Person)
        {
            Console.WriteLine("ID:" + Person.Item1 + " Name:" + Person.Item2);
        }

        public static Tuple<int, string> GetPerson()
        {
            return Tuple.Create(1, "Yash Dengre");
        }


        public static void ValueTuples()
        {
            //Value tuple can have more than 8 parameter    
            ValueTuple<int, string, string> Person = (1, "Yash", "Dengre");
            var anotherPerson = (1, "Another", "Person");
            (int, string, long) AnotherWay = (1, "DexJar", 20901239123);

            //Tuple requires at least two values. The following is NOT a tuple.

            var number = (1);  // int type, NOT a tuple
            var numbers = (1, 2); //valid tuple
            //Unlike Tuple, a ValueTuple can include more than eight values.
            var numbers_ = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14);
            //Named Members

            (int Id, string FirstName, string LastName) NamedPerson = (1, "Yash", "Dengre");
            //Named - assign only either side {Left or Right} 
            // If you have provided at both side it will cosider the left one and ignore the right one
            var RightNamed = (ID: 12, Name: "Yash Dengre", Company: "DexJar");
            //BothSide and assign the varibale directly
            int ID = 12312;
            string Name = "DexJar";
            (int Id, string Name) BothSideAndVariable = (PID: ID, PNAME: Name);
            Console.WriteLine($"Person : {Person} , item1: {Person.Item1}, item2: {Person.Item2}, item3: {Person.Item3}");
            Console.WriteLine($"AnotherPerson : {anotherPerson} , item1: {anotherPerson.Item1}, item2: {anotherPerson.Item2}");
            Console.WriteLine($"AnotherWay : {AnotherWay} , item1: {AnotherWay.Item1}, item2: {AnotherWay.Item2}, item3: {AnotherWay.Item3}");
            Console.WriteLine($"only one parameter will make the tuple as normal data type:");
            Console.WriteLine($"Example : var number = (1) => type: {number.GetType()} and var numbers = (1,2) => type: {numbers.GetType()}");
            Console.WriteLine($"Named Persons: {NamedPerson}, item1 = Id: {NamedPerson.Id}, item2 = FirstName: {NamedPerson.FirstName}, item3 = LastName: {NamedPerson.LastName}");
            Console.WriteLine($"Right Named: {RightNamed}, item1 = ID: {RightNamed.ID}, item2 = Name: {RightNamed.Name}, item3 = Company: {RightNamed.Company}");
            Console.WriteLine($"Both Side And Variable :It considered the left side name: {BothSideAndVariable}, item1 = Id: {BothSideAndVariable.Id}, item2 = Name: {BothSideAndVariable.Name}");

        }

        //we can also accept it as (int,string) person or also can use named parameters
        public static void ValueTupleAsParameter(ValueTuple<int, string> Person)
        {
            Console.WriteLine($"Person: {Person}, item1: {Person.Item1}, item2: {Person.Item2}");
        }
        public static (int, string, string) ValueTupleAsReturnType()
        {
            return (ID: 1, Name: "Yash Dengre", Company: "DexJar");
        }

    }

    class Caller
    {
        public static void Main6(string[] args)
        {
            //Tuple
            Console.WriteLine(CustomTuple.GetPerson());
            CustomTuple.Tuples();
            CustomTuple.TupleAsParameter(Tuple.Create(1, "TupleAsParameter"));

            //Value Tuple
            CustomTuple.ValueTuples();
            Console.WriteLine("As a Parameter : ValueTuple");
            CustomTuple.ValueTupleAsParameter((1, "Yash Dengre"));
            Console.WriteLine("As a retrn type : ValueTuple");
            Console.WriteLine(CustomTuple.ValueTupleAsReturnType());

            //Deconstruction -  ValueTuple
            (int, string, string) person = CustomTuple.ValueTupleAsReturnType();
            Console.WriteLine("Deconstruction into Person Varibale : " + person);
            //discards
            var (Id, Name, _) = CustomTuple.ValueTupleAsReturnType();
            Console.WriteLine($"After Discarding the 3rd Value: and Named Parameter : {Environment.NewLine}" +
                $"Id: {Id}, Name: {Name}");



            Console.ReadKey();
        }
    }
}
