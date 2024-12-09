using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BE;
using BL;

namespace UI
{
    public partial class AutorRegistrar : Utilidades
    {

        //referencia
        private AutorBL autorBL = new AutorBL();
        private PaisBL paisBL = new PaisBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) 
            {
                ddlNacionalidad.DataSource = paisBL.FindAll();
                ddlNacionalidad.DataValueField = "ID";
                ddlNacionalidad.DataTextField = "Descripcion";
                ddlNacionalidad.DataBind();
                
            }

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            //si esta autenticado
            if (User.Identity.IsAuthenticated)
            {
                if (User.IsInRole("USER"))
                {
                    if (Page.IsValid)
                    {
                        //entrada
                        string apellido = txtApellido.Text;
                        string nombre = txtNombre.Text;
                        DateTime fechaNacimiento = Convert.ToDateTime(txtFechaNacimiento.Text);


                        int nacionalidad = Convert.ToInt32(ddlNacionalidad.SelectedValue.ToString());

                        //proceso
                        AutorBE autorBE = new AutorBE(apellido, nombre, fechaNacimiento, nacionalidad);
                        autorBL.insert(autorBE);


                        //salida
                        Response.Redirect("~/Default");
                    }
                    else
                    {
                        MessageBox("Error,campo no validados");
                    }

                }
                else
                {
                    MessageBox("Error, su rol no se lo permite");
                }

            }
            else 
            {
                MessageBox("Error, deber iniciar sesión");
            }


        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AutorListar");
        }
    }
}