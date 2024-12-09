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
    public class GeneroBL
    {
        public GeneroBL() { }

        public void insert(GeneroBE generoBE)
        {
            //conexion DB
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConnection.Open();

                //SQL insert
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "insert into Generos values(@Descripcion)";

                //Load parameters
                sqlCommand.Parameters.AddWithValue("@ID", generoBE.ID);
                sqlCommand.Parameters.AddWithValue("@Descripcion", generoBE.Descripcion);


                //execute
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

            }
        }

        public void update(GeneroBE generoBE)
        {
            //conexion DB
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConnection.Open();

                //SQL insert
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "update Generos set Descripcion=@Descripcion where ID=@ID";

                //Load parameters
                sqlCommand.Parameters.AddWithValue("@ID", generoBE.ID);
                sqlCommand.Parameters.AddWithValue("@Descripcion", generoBE.Descripcion);

                //execute
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

            }
        }


        public void delete(int generoID)
        {
            //conexion DB
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConnection.Open();

                //SQL insert
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "delete from Generos where ID=@ID";

                //Load parameters
                sqlCommand.Parameters.AddWithValue("@ID", generoID);




                //execute
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

            }
        }

        public GeneroBE FindById(int generoID)
        {
            GeneroBE generoBE = null;

            //conexion DB
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConnection.Open();

                //SQL insert
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "select * from Generos where ID=@ID";

                //Load parameters
                sqlCommand.Parameters.AddWithValue("@ID", generoID);



                //execute
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.Read())
                {
                    generoBE = new GeneroBE();

                    generoBE.ID = sqlDataReader.GetInt32(0);
                    generoBE.Descripcion = sqlDataReader.GetString(1);
                }

                sqlDataReader.Close();
                sqlConnection.Close();



            }

            return generoBE;


        }


        public List<GeneroBE> FindAll()
        {
            List<GeneroBE> list = new List<GeneroBE>();

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConnection.Open();

                //SQL insert
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "select * from Generos order by ID";



                //execute
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    GeneroBE generoBE = new GeneroBE();

                    generoBE.ID = sqlDataReader.GetInt32(0);
                    generoBE.Descripcion = sqlDataReader.GetString(1);

                    list.Add(generoBE);

                }

                sqlDataReader.Close();
                sqlConnection.Close();
            }

            return list;
        }

        public bool isDelete(int generoID)
        {
            bool delete = true;

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConnection.Open();

                //SQL insert
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "select * from Libros where IdGenero=@ID";

                //Load parameters
                sqlCommand.Parameters.AddWithValue("@ID", generoID);

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
    }
}
