using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//libreria exlusiva para conexión a SQLServer
using System.Data.SqlClient;

namespace DB
{
    public class ConnectionDB
    {
        public static string SQLServer() 
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            //servidor
            builder.DataSource = "Admin";

            //base de datos
            builder.InitialCatalog = "Biblioteca";

            //usuario
            builder.UserID = "sa";

            //contraseña
            builder.Password = "123";

            //login SQL Server Authentication
            builder.IntegratedSecurity = false;

            //login windows SQL Server Authentication
            //builder.IntegratedSecurity = true;

            return builder.ToString();
        }
    }
}
