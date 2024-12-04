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
    public partial class LibroRegistrar : Utilidades
    {

        //referencia
        private LibroBL libroBL = new LibroBL();
        private GeneroBL generoBL = new GeneroBL();
        private EditorialBL editorialBL = new EditorialBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ddlGenero.DataSource = generoBL.FindAll();
                ddlGenero.DataValueField = "ID";
                ddlGenero.DataTextField = "Descripcion";
                ddlGenero.DataBind();


                ddlEditorial.DataSource = editorialBL.FindAll();
                ddlEditorial.DataValueField = "ID";
                ddlEditorial.DataTextField = "Descripcion";
                ddlEditorial.DataBind();

            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                //entrada
                string isbn = txtISBN.Text;
                string titulo = txtTitulo.Text;
                int edicion = Convert.ToInt32(txtEdicion.Text);

                int genero = Convert.ToInt32(ddlGenero.SelectedValue.ToString());

                int editorial = Convert.ToInt32(ddlEditorial.SelectedValue.ToString());


                //proceso
                if (!libroBL.IsUnique(isbn))
                {
                    LibroBE libroBE = new LibroBE(isbn, titulo, edicion, genero, editorial);
                    libroBL.insert(libroBE);
                    //salida
                    Response.Redirect("~/Default");
                }
                else
                {
                    MessageBox("Error: El ISBN ingresado ya existe. Por favor, ingrese un ISBN único.");
                }

               
            }
            else
            {
                MessageBox("Error,campo no validados");
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/LibroListar");
        }
    }
}