using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace AppWebAlmacenCentral
{
    public partial class ProveedorListar : Utilidades
    {
        private ProveedorBL proveedorBL = new ProveedorBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                    // Cargar los datos de los proveedores
                    gvProveedores.DataSource = proveedorBL.FindAll();
                    gvProveedores.DataBind(); // Mostrar los proveedores en la página
               
            }
        }

        protected void gvProveedores_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvProveedores.PageIndex = e.NewPageIndex;
            gvProveedores.DataSource = proveedorBL.FindAll();
            gvProveedores.DataBind();
        }
    }
}