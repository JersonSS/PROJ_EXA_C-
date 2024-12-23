﻿using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BL;
using BE;

namespace UI
{
    public partial class AutorBorrar : Utilidades
    {
        private AutorBL autorBL = new AutorBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(Request.QueryString["paramID"]);
            AutorBE autorBE = autorBL.FindById(ID);

            if (!IsPostBack) 
            {
                txtID.Text = autorBE.ID.ToString();
                txtApellido.Text = autorBE.Apellido.ToString();
                txtNombre.Text = autorBE.Nombre.ToString();
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AutorListar");
        }


        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            //si esta autenticado
            if (User.Identity.IsAuthenticated)
            {
                if (User.IsInRole("ADMIN"))
                {
                    int ID = Convert.ToInt32(txtID.Text);

                    bool isDelete = autorBL.isDelete(ID);
                    if (!isDelete)
                    {
                        autorBL.delete(ID);
                        Response.Redirect("~/AutorListar");
                    }
                    else
                    {
                        MessageBox("Error, no se puede por que esta asociado");
                    }
                }
                else
                {
                    MessageBox("Error, su rol no se le permite");
                }
            }
            else 
            {
                MessageBox("Error, debe iniciar sesión primero.");
            }

            
        }
    }
}