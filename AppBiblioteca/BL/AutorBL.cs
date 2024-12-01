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
                sqlCommand.CommandText = "insert into Autores values(@Apellido, @Nombre, @FechaNacimiento, @Nacionalidad)";

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

        public AutorBE FindById(int autorID) 
        {
            AutorBE autorBE = null;

            //conexion DB
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConnection.Open();

                //SQL insert
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "select * from Autores where ID=@ID";

                //Load parameters
                sqlCommand.Parameters.AddWithValue("@ID", autorID);



                //execute
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.Read()) 
                {
                    autorBE = new AutorBE();

                    autorBE.ID = sqlDataReader.GetInt32(0);
                    autorBE.Apellido = sqlDataReader.GetString(1);
                    autorBE.Nombre = sqlDataReader.GetString(2);
                    autorBE.FechaNacimineto = sqlDataReader.GetDateTime(3);
                    autorBE.Nacionalidad =sqlDataReader.GetInt32(4);
                }
                
                sqlDataReader.Close();
                sqlConnection.Close();



            }

            return autorBE;


        }


        public List<AutorBE> FindAll()
        { 
            List<AutorBE> list = new List<AutorBE>();

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConnection.Open();

                //SQL insert
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "select * from Autores";



                //execute
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    AutorBE autorBE = new AutorBE();

                    autorBE.ID = sqlDataReader.GetInt32(0);
                    autorBE.Apellido = sqlDataReader.GetString(1);
                    autorBE.Nombre = sqlDataReader.GetString(2);
                    autorBE.FechaNacimineto = sqlDataReader.GetDateTime(3);
                    autorBE.Nacionalidad = sqlDataReader.GetInt32(4);

                    list.Add(autorBE);

                }

                sqlDataReader.Close();
                sqlConnection.Close();
            }

            return list;
        }



    }
}
