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
    public class PaisBL
    {
        public PaisBL() { }

        public List<PaisBE> FindAll() 
        {
            List<PaisBE> list = new List<PaisBE>();

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "select * from Paises order by ID";

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read()) 
                {
                    PaisBE paisBE = new PaisBE();

                    paisBE.ID = sqlDataReader.GetInt32(0);
                    paisBE.Descripcion = sqlDataReader.GetString(1);

                    list.Add(paisBE);

                }

                sqlDataReader.Close();
                sqlConnection.Close();

            }

            return list;

        }

    }
}
