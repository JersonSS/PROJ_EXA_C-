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

            //servidor senati
            //builder.DataSource = "Admin";

            //servidor sin autententicacion windows 
            //builder.DataSource = "DESKTOP-S98UCTP\\SQLEXPRESS";

            //servidor con autententicacion windows 
            builder.DataSource = "DESKTOP-S98UCTP\\SQLEXPRESS";


            //base de datos
            builder.InitialCatalog = "Biblioteca";

            //usuario y contraseña senati
            //builder.UserID = "sa";
            //builder.Password = "123";

            //usuario y contraseña yo
            //builder.UserID = "jersonss";
            //builder.Password = "1234";

            //login SQL Server Authentication
            //builder.IntegratedSecurity = false;

            //login windows SQL Server Authentication
            builder.IntegratedSecurity = true;

            return builder.ToString();
        }
    }
}
