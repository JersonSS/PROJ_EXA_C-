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
    public partial class LibroEditar : Utilidades
    {
        private LibroBL libroBL = new LibroBL();
        private GeneroBL generoBL = new GeneroBL();
        private EditorialBL editorialBL = new EditorialBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            string ISBN = Request.QueryString["paramISBN"];
            LibroBE libroBE = libroBL.FindById(ISBN);

            if (!IsPostBack)
            {
                txtISBN.Text = libroBE.ISBN.ToString();
                txtTitulo.Text = libroBE.Titulo.ToString();
                txtEdicion.Text = libroBE.Edicion.ToString();

                ddlGenero.DataSource = generoBL.FindAll();
                ddlGenero.DataTextField = "Descripcion";
                ddlGenero.DataValueField = "ID";
                ddlGenero.DataBind();
                ddlGenero.SelectedValue = libroBE.IdGenero.ToString();

                ddlEditorial.DataSource = editorialBL.FindAll();
                ddlEditorial.DataTextField = "Descripcion";
                ddlEditorial.DataValueField = "ID";
                ddlEditorial.DataBind();
                ddlEditorial.SelectedValue = libroBE.IdEditorial.ToString();
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

                    LibroBE libroBE = new LibroBE(isbn, titulo, edicion, genero, editorial);
                    libroBL.update(libroBE);
                    //salida
                    Response.Redirect("~/LibroListar");


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