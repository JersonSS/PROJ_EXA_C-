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
    public partial class GeneroEditar : Utilidades
    {
        private GeneroBL generoBL = new GeneroBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            int idGenero = Convert.ToInt32(Request.QueryString["paramID"]);
            GeneroBE generoBE = generoBL.FindById(idGenero);

            if (!IsPostBack)
            {
                // Cargar los datos existentes del género
                txtID.Text = generoBE.ID.ToString();
                txtDescripcion.Text = generoBE.Descripcion.ToString();

            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                //entrada
                int idGenero = Convert.ToInt32(txtID.Text);
                string descripcion = txtDescripcion.Text;

                //proceso
                GeneroBE generoBE = new GeneroBE(idGenero, descripcion);
                generoBL.update(generoBE);

                //salida
                Response.Redirect("~/GeneroListar");
            }
            else
            {
                MessageBox("Error, campo no validado");
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/GeneroListar");
        }
    }
}