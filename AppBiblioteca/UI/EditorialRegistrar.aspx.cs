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
    public partial class EditorialRegistrar : Utilidades
    {
        private EditorialBL editorialBL = new EditorialBL();
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
                EditorialBE editorialBE = new EditorialBE(descripcion);
                editorialBL.insert(editorialBE);

                // Salida
                Response.Redirect("~/EditorialListar");
            }
            else
            {
                MessageBox("Error: Campos no validados correctamente.");
            }

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/EditorialListar");
        }
    }
}