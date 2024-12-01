using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BE;
using BL;

namespace UI
{
    public partial class AutorRegistrar : System.Web.UI.Page
    {

        //referencia
        private AutorBL autorBL = new AutorBL();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            //entrada
            string apellido = txtApellido.Text;
            string nombre = txtNombre.Text;
            DateTime fechaNacimiento = Convert.ToDateTime(txtFechaNacimiento.Text);
            int nacionalidad = Convert.ToInt32(txtNacionalidad.Text);

            //proceso
            AutorBE autorBE = new AutorBE(apellido, nombre, fechaNacimiento, nacionalidad);
            autorBL.insert(autorBE);


            //salida
            Response.Redirect("~/Default");


        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default");
        }
    }
}