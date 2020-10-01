using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ADO_DOTNET_LINQ
{
    public class Connectivity
    {

        SqlConnection _connection;
        SqlCommand command;
        string connectionString;
        static CommandType.Command Type;
        public string OutputForSelect = "";
        public DataSet returnData;
        public Connectivity()
        {

        }
        public Connectivity(string query, CommandType.Command commandType, string dataSource = "")
        {
            if (string.IsNullOrEmpty(dataSource))
            {
                connectionString = @"Data Source=HP-PC\SQLEXPRESS;Initial Catalog=PRACTICE;Integrated Security=True";
            }
            else { connectionString = dataSource; }
            _connection = new SqlConnection(connectionString);
            command = new SqlCommand(query, _connection);
            Type = commandType;

        }
        public void ExecuteQuery()
        {
            switch (Type)
            {
                case CommandType.Command.CREATE:
                    Create();
                    break;
                case CommandType.Command.INSERT:
                    Insert();
                    break;
                case CommandType.Command.SELECT:
                    SELECT(out OutputForSelect);
                    break;
                case CommandType.Command.UPDATE:
                    UPDATE();
                    break;
                case CommandType.Command.DELETE:
                    DELETE();
                    break;
                case CommandType.Command.SELECTDATASET:
                    DataSetSelect();
                    break;
                default:
                    throw new System.Exception("Invalid Command Type");
            }
        }

        private void DELETE()
        {
            OpenConnection(_connection);
            command.CommandType = System.Data.CommandType.Text;
            int result = command.ExecuteNonQuery();
            if (Convert.ToBoolean(result) == true)
            {
                Console.WriteLine("Data is Deleted");
            }
            CloseConnection(_connection);
        }

        private void UPDATE()
        {
            OpenConnection(_connection);
            CloseConnection(_connection);
        }

        private void SELECT(out string Output)
        {
            OpenConnection(_connection);
            command.CommandType = System.Data.CommandType.Text;
            string ReturnData = "";
            int result = command.ExecuteNonQuery();
            if (Convert.ToBoolean(result) == true)
            {
                var DataReader = command.ExecuteReader();

                List<string> data = new List<string>();
                while (DataReader.Read() && DataReader.HasRows)
                {
                    ReturnData += "Id : " + DataReader.GetValue(0) + "Name : " + DataReader.GetValue(1) + "\n";
                }

            }
            Output = ReturnData;
            CloseConnection(_connection);
        }

        private void Insert()
        {
            OpenConnection(_connection);
            command.CommandType = System.Data.CommandType.Text;
            var result = command.ExecuteNonQuery();
            if (Convert.ToBoolean(result) == true)
            {
                Console.WriteLine("Data is inserted");
            }
            CloseConnection(_connection);
        }
        private void Create()
        {
            OpenConnection(_connection);
            command.CommandType = System.Data.CommandType.Text;
            int result = command.ExecuteNonQuery();
            if (Convert.ToBoolean(result) == true)
            {
                Console.WriteLine("Table is created");
            }
            CloseConnection(_connection);
        }

        private void DataSetSelect()
        {
            OpenConnection(_connection);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM TEMPORARY", _connection);
            DataSet DS = new DataSet();
            sda.Fill(DS);
            returnData = DS;
            CloseConnection(_connection);
        }

        /// <summary>
        /// OpenConnection - open the sql connection if connection is not open already
        /// </summary>
        /// <param name="connection"></param>
        public static void OpenConnection(SqlConnection connection)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }
        /// <summary>
        /// CloseConnection -  close te sql connection if connection is not closed already
        /// </summary>
        /// <param name="connection"></param>
        public static void CloseConnection(SqlConnection connection)
        {
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }
    }
}
