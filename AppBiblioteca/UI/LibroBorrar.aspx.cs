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
    public partial class LibroBorrar : Utilidades
    {
        private LibroBL libroBL = new LibroBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            string ISBN = Request.QueryString["paramISBN"];
            LibroBE libroBE = libroBL.FindById(ISBN);

            if (!IsPostBack)
            {
                txtISBN.Text = libroBE.ISBN;
                txtTitulo.Text = libroBE.Titulo;
                txtEdicion.Text = libroBE.Edicion.ToString();
            }
        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            string ISBN = txtISBN.Text;

            bool isDelete = libroBL.isDelete(ISBN);
            if (isDelete)
            {
                libroBL.delete(ISBN);
                Response.Redirect("~/LibroListar");
            }
            else
            {
                MessageBox("Error, no se puede eliminar porque está asociado a otras entidades.");
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/LibroListar");
        }
    }
}