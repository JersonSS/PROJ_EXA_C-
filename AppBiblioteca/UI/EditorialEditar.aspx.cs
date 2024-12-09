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
    public partial class EditorialEditar : Utilidades
    {
        private EditorialBL editorialBL = new EditorialBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            int idEditorial = Convert.ToInt32(Request.QueryString["paramID"]);
            EditorialBE editorialBE = editorialBL.FindById(idEditorial);

            if (!IsPostBack)
            {
                // Cargar los datos existentes del género
                txtID.Text = editorialBE.ID.ToString();
                txtDescripcion.Text = editorialBE.Descripcion.ToString();

            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                //entrada
                int idEditorial = Convert.ToInt32(txtID.Text);
                string descripcion = txtDescripcion.Text;

                //proceso
                EditorialBE editorialBE = new EditorialBE(idEditorial, descripcion);
                editorialBL.update(editorialBE);

                //salida
                Response.Redirect("~/EditorialListar");
            }
            else
            {
                MessageBox("Error, campo no validado");
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/EditorialListar");
        }
    }
}