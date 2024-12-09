using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BE;
using BL;

namespace UI
{
    public partial class GeneroRegistrar : Utilidades
    {
        private GeneroBL generoBL = new GeneroBL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                // Entrada
                string descripcion = txtDescripcion.Text.Trim();

                // Proceso
                GeneroBE generoBE = new GeneroBE(descripcion);
                generoBL.insert(generoBE);

                // Salida
                Response.Redirect("~/GeneroListar");
            }
            else
            {
                MessageBox("Error: Campos no validados correctamente.");
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/GeneroListar");
        }


    }
}