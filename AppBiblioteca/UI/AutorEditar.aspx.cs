using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BE;
using BL;

namespace UI
{
    public partial class AutorEditar : System.Web.UI.Page
    {

        private AutorBL autorBL = new AutorBL();

        protected void Page_Load(object sender, EventArgs e)
        {
           
            int ID=Convert.ToInt32(Request.QueryString["paramID"]);
            AutorBE autorBE = autorBL.FindById(ID);

            if (!IsPostBack) 
            {
                txtID.Text = autorBE.ID.ToString();
                txtApellido.Text=autorBE.Apellido.ToString();
                txtNombre.Text=autorBE.Nombre.ToString();
                txtFechaNacimiento.Text = autorBE.FechaNacimiento.ToString();
                txtNacionalidad.Text= autorBE.Nacionalidad.ToString();
            }

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            //entrada
            int ID = Convert.ToInt32(txtID.Text);
            string apellido = txtApellido.Text;
            string nombre = txtNombre.Text;
            DateTime fechaNacimiento = Convert.ToDateTime(txtFechaNacimiento.Text);
            int nacionalidad = Convert.ToInt32(txtNacionalidad.Text);

            //proceso
            AutorBE autorBE = new AutorBE(ID, apellido, nombre, fechaNacimiento, nacionalidad);
            autorBL.update(autorBE);


            //salida
            Response.Redirect("~/AutorListar");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AutorListar");
        }
    }
}