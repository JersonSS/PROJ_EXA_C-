using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using BE;
using DB;

namespace BL
{
    public class AutorBL
    {
        public AutorBL() { }

        public void insert(AutorBE autorBE) 
        {
            //conexion DB
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConnection.Open();

                //SQL insert
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "insert into Autores values(@Apellido, @Nombre, @FechaNacimiento, @Nacionaliadad)";

                //Load parameters
                sqlCommand.Parameters.AddWithValue("@Apellido", autorBE.Apellido);
                sqlCommand.Parameters.AddWithValue("@Nombre", autorBE.Nombre);
                sqlCommand.Parameters.AddWithValue("@FechaNacimiento", autorBE.FechaNacimineto);
                sqlCommand.Parameters.AddWithValue("@Nacionalidad", autorBE.Nacionalidad);


                //execute
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

            }
        }

        public void update(AutorBE autorBE)
        {
            //conexion DB
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConnection.Open();

                //SQL insert
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "update Autores set Apellido=@Apellido, Nombre=@Nombre, FechaNacimiento=@FechaNacimiento, Nacionalidad=@Nacionaliadad where ID=@ID";

                //Load parameters
                sqlCommand.Parameters.AddWithValue("@Apellido", autorBE.Apellido);
                sqlCommand.Parameters.AddWithValue("@Nombre", autorBE.Nombre);
                sqlCommand.Parameters.AddWithValue("@FechaNacimiento", autorBE.FechaNacimineto);
                sqlCommand.Parameters.AddWithValue("@Nacionalidad", autorBE.Nacionalidad);
                sqlCommand.Parameters.AddWithValue("@ID", autorBE.ID);

                //execute
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

            }
        }


        public void delete(int autorID)
        {
            //conexion DB
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConnection.Open();

                //SQL insert
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "delete from Autores where ID=@ID";

                //Load parameters
                sqlCommand.Parameters.AddWithValue("@ID",autorID);



                //execute
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

            }
        }


    }
}
