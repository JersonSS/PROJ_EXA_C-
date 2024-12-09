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
    public class EditorialBL
    {
        public EditorialBL() { }

        public void insert(EditorialBE editorialBE)
        {
            //conexion DB
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConnection.Open();

                //SQL insert
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "insert into Editoriales values(@Descripcion)";

                //Load parameters
                sqlCommand.Parameters.AddWithValue("@ID", editorialBE.ID);
                sqlCommand.Parameters.AddWithValue("@Descripcion", editorialBE.Descripcion);


                //execute
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

            }
        }

        public void update(EditorialBE editorialBE)
        {
            //conexion DB
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConnection.Open();

                //SQL insert
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "update Editoriales set Descripcion=@Descripcion where ID=@ID";

                //Load parameters
                sqlCommand.Parameters.AddWithValue("@ID", editorialBE.ID);
                sqlCommand.Parameters.AddWithValue("@Descripcion", editorialBE.Descripcion);

                //execute
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

            }
        }


        public void delete(int editorialID)
        {
            //conexion DB
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConnection.Open();

                //SQL insert
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "delete from Editoriales where ID=@ID";

                //Load parameters
                sqlCommand.Parameters.AddWithValue("@ID", editorialID);




                //execute
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

            }
        }

        public EditorialBE FindById(int editorialID)
        {
            EditorialBE editorialBE = null;

            //conexion DB
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConnection.Open();

                //SQL insert
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "select * from Editoriales where ID=@ID";

                //Load parameters
                sqlCommand.Parameters.AddWithValue("@ID", editorialID);



                //execute
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.Read())
                {
                    editorialBE = new EditorialBE();

                    editorialBE.ID = sqlDataReader.GetInt32(0);
                    editorialBE.Descripcion = sqlDataReader.GetString(1);
                }

                sqlDataReader.Close();
                sqlConnection.Close();



            }

            return editorialBE;


        }


        public List<EditorialBE> FindAll()
        {
            List<EditorialBE> list = new List<EditorialBE>();

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConnection.Open();

                //SQL insert
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "select * from Editoriales order by ID";



                //execute
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    EditorialBE editorialBE = new EditorialBE();

                    editorialBE.ID = sqlDataReader.GetInt32(0);
                    editorialBE.Descripcion = sqlDataReader.GetString(1);

                    list.Add(editorialBE);

                }

                sqlDataReader.Close();
                sqlConnection.Close();
            }

            return list;
        }

        public bool isDelete(int editorialID)
        {
            bool delete = true;

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConnection.Open();

                //SQL insert
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "select * from Libros where IdEditorial=@ID";

                //Load parameters
                sqlCommand.Parameters.AddWithValue("@ID", editorialID);

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
