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
    public class ProveedorBL
    {
        public ProveedorBL() { }

        // Método para insertar un proveedor
        public void insert(ProveedorBE proveedorBE)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConnection.Open();

                // SQL Insert
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "insert into Proveedores (idProveedor, nombre, representante, direccion, ciudad, departamento, codigoPostal, telefono, fax) " +
                                         "values (@IdProveedor, @Nombre, @Representante, @Direccion, @Ciudad, @Departamento, @CodigoPostal, @Telefono, @Fax)";

                // Cargar parámetros
                sqlCommand.Parameters.AddWithValue("@IdProveedor", proveedorBE.IdProveedor);
                sqlCommand.Parameters.AddWithValue("@Nombre", proveedorBE.Nombre);
                sqlCommand.Parameters.AddWithValue("@Representante", proveedorBE.Representante);
                sqlCommand.Parameters.AddWithValue("@Direccion", proveedorBE.Direccion);
                sqlCommand.Parameters.AddWithValue("@Ciudad", proveedorBE.Ciudad);
                sqlCommand.Parameters.AddWithValue("@Departamento", proveedorBE.Departamento);
                sqlCommand.Parameters.AddWithValue("@CodigoPostal", proveedorBE.CodigoPostal);
                sqlCommand.Parameters.AddWithValue("@Telefono", proveedorBE.Telefono);
                sqlCommand.Parameters.AddWithValue("@Fax", proveedorBE.Fax);

                // Ejecutar
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        // Método para actualizar un proveedor
        public void update(ProveedorBE proveedorBE)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConnection.Open();

                // SQL Update
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "update Proveedores set nombre=@Nombre, representante=@Representante, direccion=@Direccion, ciudad=@Ciudad, " +
                                         "departamento=@Departamento, codigoPostal=@CodigoPostal, telefono=@Telefono, fax=@Fax where idProveedor=@IdProveedor";

                // Cargar parámetros
                sqlCommand.Parameters.AddWithValue("@Nombre", proveedorBE.Nombre);
                sqlCommand.Parameters.AddWithValue("@Representante", proveedorBE.Representante);
                sqlCommand.Parameters.AddWithValue("@Direccion", proveedorBE.Direccion);
                sqlCommand.Parameters.AddWithValue("@Ciudad", proveedorBE.Ciudad);
                sqlCommand.Parameters.AddWithValue("@Departamento", proveedorBE.Departamento);
                sqlCommand.Parameters.AddWithValue("@CodigoPostal", proveedorBE.CodigoPostal);
                sqlCommand.Parameters.AddWithValue("@Telefono", proveedorBE.Telefono);
                sqlCommand.Parameters.AddWithValue("@Fax", proveedorBE.Fax);
                sqlCommand.Parameters.AddWithValue("@IdProveedor", proveedorBE.IdProveedor);

                // Ejecutar
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        // Método para eliminar un proveedor
        public void delete(decimal idProveedor)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConnection.Open();

                // SQL Delete
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "delete from Proveedores where idProveedor=@IdProveedor";

                // Cargar parámetro
                sqlCommand.Parameters.AddWithValue("@IdProveedor", idProveedor);

                // Ejecutar
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        // Método para encontrar un proveedor por ID
        public ProveedorBE FindById(decimal idProveedor)
        {
            ProveedorBE proveedorBE = null;

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConnection.Open();

                // SQL Select
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "select * from Proveedores where idProveedor=@IdProveedor";

                // Cargar parámetro
                sqlCommand.Parameters.AddWithValue("@IdProveedor", idProveedor);

                // Ejecutar
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.Read())
                {
                    proveedorBE = new ProveedorBE();
                    proveedorBE.IdProveedor = sqlDataReader.GetDecimal(0);
                    proveedorBE.Nombre = sqlDataReader.GetString(1);
                    proveedorBE.Representante = sqlDataReader.GetString(2);
                    proveedorBE.Direccion = sqlDataReader.GetString(3);
                    proveedorBE.Ciudad = sqlDataReader.GetString(4);
                    proveedorBE.Departamento = sqlDataReader.GetString(5);
                    proveedorBE.CodigoPostal = !sqlDataReader.IsDBNull(6) ? sqlDataReader.GetString(6) : string.Empty;
                    proveedorBE.Telefono = !sqlDataReader.IsDBNull(7) ? sqlDataReader.GetString(7) : string.Empty;
                    proveedorBE.Fax = !sqlDataReader.IsDBNull(8) ? sqlDataReader.GetString(8) : string.Empty;
                }

                sqlDataReader.Close();
                sqlConnection.Close();
            }

            return proveedorBE;
        }

        // Método para obtener todos los proveedores
        public List<ProveedorBE> FindAll()
        {
            List<ProveedorBE> list = new List<ProveedorBE>();

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConnection.Open();

                // SQL Select
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "select * from Proveedores";

                // Ejecutar
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    ProveedorBE proveedorBE = new ProveedorBE();
                    proveedorBE.IdProveedor = !sqlDataReader.IsDBNull(0) ? sqlDataReader.GetDecimal(0) : 0;
                    proveedorBE.Nombre = !sqlDataReader.IsDBNull(1) ? sqlDataReader.GetString(1) : string.Empty;
                    proveedorBE.Representante = !sqlDataReader.IsDBNull(2) ? sqlDataReader.GetString(2) : string.Empty;
                    proveedorBE.Direccion = !sqlDataReader.IsDBNull(3) ? sqlDataReader.GetString(3) : string.Empty;
                    proveedorBE.Ciudad = !sqlDataReader.IsDBNull(4) ? sqlDataReader.GetString(4) : string.Empty;
                    proveedorBE.Departamento = !sqlDataReader.IsDBNull(5) ? sqlDataReader.GetString(5) : string.Empty;
                    proveedorBE.CodigoPostal = !sqlDataReader.IsDBNull(6) ? sqlDataReader.GetString(6) : string.Empty;
                    proveedorBE.Telefono = !sqlDataReader.IsDBNull(7) ? sqlDataReader.GetString(7) : string.Empty;
                    proveedorBE.Fax = !sqlDataReader.IsDBNull(8) ? sqlDataReader.GetString(8) : string.Empty;

                    list.Add(proveedorBE);
                }

                sqlDataReader.Close();
                sqlConnection.Close();
            }

            return list;
        }

        // Método para verificar si un proveedor puede ser eliminado
        public bool isDelete(decimal idProveedor)
        {
            bool delete = true;

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConnection.Open();

                // SQL Check
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "select * from Productos where idProveedor=@IdProveedor";

                // Cargar parámetro
                sqlCommand.Parameters.AddWithValue("@IdProveedor", idProveedor);

                // Ejecutar
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



        public bool IsUnique(decimal idProveedor)
        {
            bool unique = true;

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConnection.Open();

                //SQL insert
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "select * from Productos where idProveedor=@IdProveedor";

                //Load parameters
                sqlCommand.Parameters.AddWithValue("@IdProveedor", idProveedor);

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
