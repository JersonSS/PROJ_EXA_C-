using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BE;
using BL;

namespace AppWebAlmacenCentral
{
    public partial class ProveedorRegistrar : Utilidades
    {
        private ProveedorBL proveedorBL = new ProveedorBL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                // Entrada de datos
                int IdGenero = Convert.ToInt32(txtID.Text);
                string nombre = txtNombre.Text;
                string representante = txtRepresentante.Text;
                string direccion = txtDireccion.Text;
                string ciudad = txtCiudad.Text;
                string departamento = txtDepartamento.Text;
                string codigoPostal = txtCodigoPostal.Text;
                string telefono = txtTelefono.Text;
                string fax = txtFax.Text;

                // Proceso
                // Verificar si el proveedor con ese nombre ya existe (puedes usar cualquier lógica que necesites)
                if (!proveedorBL.IsUnique(IdGenero))
                {
                    ProveedorBE proveedorBE = new ProveedorBE(IdGenero, nombre, representante, direccion, ciudad, departamento, codigoPostal, telefono, fax);
                    proveedorBL.insert(proveedorBE);
                    // Salida
                    Response.Redirect("~/ProveedorListar");
                }
                else
                {
                    MessageBox("Error: El proveedor con este nombre ya existe. Por favor, ingrese un nombre único.");
                }
            }
            else
            {
                MessageBox("Error: Campo no validado.");
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ProveedorListar");
        }
    }
}