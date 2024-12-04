﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


using BE;
using BL;

namespace UI
{
    public partial class LibroListar : System.Web.UI.Page
    {
        //referencia
        private LibroBL libroBL = new LibroBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                gvLibros.DataSource = libroBL.FindAll();
                gvLibros.DataBind();//haga el efecto de mostrar los actores en la pagina

            }

        }


        protected void gvLibros_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvLibros.PageIndex = e.NewPageIndex;
            gvLibros.DataSource = libroBL.FindAll();
            gvLibros.DataBind();
        }
    }
}