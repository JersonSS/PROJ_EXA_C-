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
    public partial class AutorListar : System.Web.UI.Page
    {
        //referencia
        private AutorBL autorBL = new AutorBL();    


        //metodo arrancador
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                gvAutores.DataSource = autorBL.FindAll();
                gvAutores.DataBind();//haga el efecto de mostrar los actores en la pagina

            }
        }

        protected void gvAutores_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvAutores.PageIndex = e.NewPageIndex;
            gvAutores.DataSource =autorBL.FindAll();
            gvAutores.DataBind();
        }
    }
}