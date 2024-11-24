using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace DB
{
    internal class ConnectionTest
    {
        public static void Main(String[] args) 
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionDB.SQLServer())) 
            {
                sqlConnection.Open();
                Console.WriteLine("Conexión exitosa!");
                sqlConnection.Close();
            }

            Console.ReadLine();
        }
    }
}
