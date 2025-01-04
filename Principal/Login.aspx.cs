using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Principal
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Simulación de autenticación básica
            if (username == "admin" && password == "password")
            {
                Response.Redirect("HomePage.aspx"); // Redirigir a la página principal o dashboard
            }
            else
            {
                // Mostrar un mensaje de error
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Usuario o contraseña incorrectos.');", true);
            }
        }
    }
}