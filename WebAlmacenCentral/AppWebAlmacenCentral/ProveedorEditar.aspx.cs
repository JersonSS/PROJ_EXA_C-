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
    
    public partial class ProveedorEditar : Utilidades
    {
        private ProveedorBL proveedorBL = new ProveedorBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            string idProveedor = Request.QueryString["paramID"];
            ProveedorBE proveedorBE = proveedorBL.FindById(Convert.ToDecimal(idProveedor));

            if (!IsPostBack)
            {
                txtIdProveedor.Text = proveedorBE.IdProveedor.ToString();
                txtNombre.Text = proveedorBE.Nombre;
                txtRepresentante.Text = proveedorBE.Representante;
                txtDireccion.Text = proveedorBE.Direccion;
                txtCiudad.Text = proveedorBE.Ciudad;
                txtDepartamento.Text = proveedorBE.Departamento;
                txtCodigoPostal.Text = proveedorBE.CodigoPostal;
                txtTelefono.Text = proveedorBE.Telefono;
                txtFax.Text = proveedorBE.Fax;
            }

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                // Entrada de datos
                int idProveedor = Convert.ToInt32(txtIdProveedor.Text);
                string nombre = txtNombre.Text;
                string representante = txtRepresentante.Text;
                string direccion = txtDireccion.Text;
                string ciudad = txtCiudad.Text;
                string departamento = txtDepartamento.Text;
                string codigoPostal = txtCodigoPostal.Text;
                string telefono = txtTelefono.Text;
                string fax = txtFax.Text;

                // Proceso
                ProveedorBE proveedorBE = new ProveedorBE(idProveedor, nombre, representante, direccion, ciudad, departamento, codigoPostal, telefono, fax);
                proveedorBL.update(proveedorBE);

                // Salida
                Response.Redirect("~/ProveedorListar");
            }
            else
            {
                MessageBox("Error: Campos no validados.");
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ProveedorListar");
        }
    }
}