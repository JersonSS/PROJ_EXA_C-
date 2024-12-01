using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class Page1 : System.Web.UI.Page
    {
        //método arrancador
        protected void Page_Load(object sender, EventArgs e)
        {

            lblFechaHora.Text = DateTime.Now.ToString();
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            lblNombre.Text = "¡Bienvenido " + nombre + "!";
        }
    }
}