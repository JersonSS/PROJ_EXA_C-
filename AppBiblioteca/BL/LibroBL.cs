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
    public class LibroBL
    {
        public LibroBL() { }

        public void insert(LibroBE libroBE)
        {
            //conexion DB
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConnection.Open();

                //SQL insert
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "insert into Libros values(@ISBN, @Titulo, @Edicion, @IdGenero, @IdEditorial)";

                //Load parameters
                sqlCommand.Parameters.AddWithValue("@ISBN", libroBE.ISBN);
                sqlCommand.Parameters.AddWithValue("@Titulo", libroBE.Titulo);
                sqlCommand.Parameters.AddWithValue("@Edicion", libroBE.Edicion);
                sqlCommand.Parameters.AddWithValue("@IdGenero", libroBE.IdGenero);
                sqlCommand.Parameters.AddWithValue("@IdEditorial", libroBE.IdEditorial);


                //execute
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

            }
        }

        public void update(LibroBE libroBE)
        {
            //conexion DB
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConnection.Open();

                //SQL insert
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "update Libros set Titulo=@Titulo, Edicion=@Edicion, IdGenero=@IdGenero, IdEditorial=@IdEditorial where ISBN=@ISBN";

                //Load parameters
                sqlCommand.Parameters.AddWithValue("@ISBN", libroBE.ISBN);
                sqlCommand.Parameters.AddWithValue("@Titulo", libroBE.Titulo);
                sqlCommand.Parameters.AddWithValue("@Edicion", libroBE.Edicion);
                sqlCommand.Parameters.AddWithValue("@IdGenero", libroBE.IdGenero);
                sqlCommand.Parameters.AddWithValue("@IdEditorial", libroBE.IdEditorial);

                //execute
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

            }
        }


        public void delete(string isbnID)
        {
            //conexion DB
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConnection.Open();

                //SQL insert
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "delete from Libros where ISBN=@ISBN";

                //Load parameters
                sqlCommand.Parameters.AddWithValue("@ISBN", isbnID);




                //execute
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

            }
        }

        public LibroBE FindById(string isbnID)
        {
            LibroBE libroBE = null;

            //conexion DB
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConnection.Open();

                //SQL insert
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "select * from Libros where ISBN=@ISBN";

                //Load parameters
                sqlCommand.Parameters.AddWithValue("@ISBN", isbnID);



                //execute
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.Read())
                {
                    libroBE = new LibroBE();

                    libroBE.ISBN = sqlDataReader.GetString(0);
                    libroBE.Titulo= sqlDataReader.GetString(1);
                    libroBE.Edicion= sqlDataReader.GetInt32(2);
                    libroBE.IdGenero= sqlDataReader.GetInt32(3);
                    libroBE.IdEditorial= sqlDataReader.GetInt32(4);
                }

                sqlDataReader.Close();
                sqlConnection.Close();



            }

            return libroBE;


        }


        public List<LibroBE> FindAll()
        {
            List<LibroBE> list = new List<LibroBE>();

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConnection.Open();

                //SQL insert
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "select * from Libros";



                //execute
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    LibroBE libroBE = new LibroBE();

                    libroBE.ISBN = sqlDataReader.GetString(0);
                    libroBE.Titulo = sqlDataReader.GetString(1);
                    libroBE.Edicion = sqlDataReader.GetInt32(2);
                    libroBE.IdGenero = sqlDataReader.GetInt32(3);
                    libroBE.IdEditorial = sqlDataReader.GetInt32(4);

                    list.Add(libroBE);

                }

                sqlDataReader.Close();
                sqlConnection.Close();
            }

            return list;
        }

        public bool isDelete(string isbnID)
        {
            bool delete = true;

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConnection.Open();

                //SQL insert
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "select * from Libros where ISBN=@ISBN";

                //Load parameters
                sqlCommand.Parameters.AddWithValue("@ISBN", isbnID);

                //execute
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    delete = false;
                    break;
                }

                sqlDataReader.Close();
                sqlConnection.Close();

            }

            return delete;
        }

        public bool IsUnique(string isbnID)
        {
            bool unique = true;

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConnection.Open();

                //SQL insert
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "select * from Libros where ISBN=@ISBN";

                //Load parameters
                sqlCommand.Parameters.AddWithValue("@ISBN", isbnID);

                //execute
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                if (!sqlDataReader.Read())
                {
                    unique = false;
                   
                }

                sqlDataReader.Close();
                sqlConnection.Close();

            }

            return unique;
        }



    }
}
