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
    public partial class ProveedorBorrar : Utilidades
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
            }
        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            
            int idProveedor = Convert.ToInt32(txtIdProveedor.Text);

           
            bool isDelete = proveedorBL.isDelete(idProveedor);
            if (isDelete)
            {
               
                proveedorBL.delete(idProveedor);
                Response.Redirect("~/ProveedorListar");
            }
            else
            {
               
                MessageBox("Error, no se puede eliminar porque está asociado a otras entidades.");
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ProveedorListar");
        }
    }
}