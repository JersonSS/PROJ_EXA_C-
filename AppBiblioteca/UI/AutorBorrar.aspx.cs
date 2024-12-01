using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BL;
using BE;

namespace UI
{
    public partial class AutorBorrar : System.Web.UI.Page
    {
        private AutorBL autorBL = new AutorBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(Request.QueryString["paramID"]);
            AutorBE autorBE = autorBL.FindById(ID);

            if (!IsPostBack) 
            {
                txtID.Text = autorBE.ID.ToString();
                txtApellido.Text = autorBE.Apellido.ToString();
                txtNombre.Text = autorBE.Nombre.ToString();
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AutorListar");
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(txtID.Text);

            bool isDelete = autorBL.isDelete(ID);
            if (!isDelete)
            {
                autorBL.delete(ID);
                Response.Redirect("~/AutorListar");
            }
            else 
            {
                //mensaje borrar
            }


        }
    }
}