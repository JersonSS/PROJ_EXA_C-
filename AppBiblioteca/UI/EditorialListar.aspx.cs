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
    public partial class EditorialListar : System.Web.UI.Page
    {
        private EditorialBL editorialBL = new EditorialBL();



        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gvEditoriales.DataSource = editorialBL.FindAll();
                gvEditoriales.DataBind(); // Mostrar las editoriales en la página
            }
        }

        protected void gvEditoriales_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvEditoriales.PageIndex = e.NewPageIndex; // Cambiar a la página seleccionada
            gvEditoriales.DataSource = editorialBL.FindAll();
            gvEditoriales.DataBind(); // Recargar los datos
        }
    }
}