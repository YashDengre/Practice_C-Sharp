using ADO_DOTNET_LINQ;
using System;

namespace CSharpe_Learning_and_Practice.ADODOTNET_LINQ
{
    public class ADOLINQ
    {
        static Executer executer;
        static Connectivity connectivity;

        public ADOLINQ()
        {
            executer = new Executer();
            connectivity = new Connectivity();
        }

        public static void Main()
        {

            //CREATE TABLE
            //connectivity = new Connectivity(query: "CREATE TABLE TEMPORARY(ID INT, NAME VARCHAR(100))", commandType: CommandType.Command.CREATE);
            //connectivity.ExecuteQuery();

            //INSERT DATA INTO TABLE

            //connectivity = new Connectivity(query: "INSERT INTO TEMPORARY VALUES(9,'Pooja Sarwani');", commandType: CommandType.Command.INSERT);
            //connectivity.ExecuteQuery();


            //Getting The Data

            connectivity = new Connectivity(query: "SELECT * FROM TEMPORARY", commandType: CommandType.Command.SELECT);
            connectivity.ExecuteQuery();
            var result = connectivity.OutputForSelect;
            Console.WriteLine("Result:\n" + result);


            //Deleting the data
            //connectivity = new Connectivity(query: "DELETE FROM TEMPORARY WHERE ID=9", commandType: CommandType.Command.DELETE);
            //connectivity.ExecuteQuery();

            //SELECT BY DATA SET

            connectivity = new Connectivity(query: "", commandType: CommandType.Command.SELECTDATASET);
            connectivity.ExecuteQuery();
            Experiment exp = new Experiment(connectivity.returnData);
            exp.Show();
            Console.ReadKey();

        }
    }
}
