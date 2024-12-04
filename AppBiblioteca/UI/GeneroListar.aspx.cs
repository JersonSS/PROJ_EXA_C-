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
    public partial class GeneroListar : System.Web.UI.Page
    {

        private GeneroBL generoBL = new GeneroBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gvGeneros.DataSource = generoBL.FindAll();
                gvGeneros.DataBind(); // Mostrar los géneros en la página
            }

        }

        protected void gvGeneros_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvGeneros.PageIndex = e.NewPageIndex; // Cambiar a la página seleccionada
            gvGeneros.DataSource = generoBL.FindAll();
            gvGeneros.DataBind(); // Recargar los datos
        }
    }
}