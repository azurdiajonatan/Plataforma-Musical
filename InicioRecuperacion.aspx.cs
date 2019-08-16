using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace IPC2Proyect1
{
    public partial class InicioRecuperacion : System.Web.UI.Page
    {
        SqlCommand comand = new SqlCommand();
        SqlConnection conetion = new SqlConnection();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet daset = new DataSet();
        SqlDataAdapter lector = null;
       

        protected void Page_Load(object sender, EventArgs e)
        {
            conetion.ConnectionString = "Data Source=DESKTOP-8D8GHSN\\SQLEXPRESS;Initial Catalog=RegistroIPC;Integrated Security=True";
            conetion.Open();

        }

        protected void tbcancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("InicioLogin.aspx");
        }

        protected void tbrecuperar_Click(object sender, EventArgs e)
        {
            string correo = tbcorreo.Text.Trim();
            string fecha = tbfecha.Text.Trim();
            int i = 0;
            comand.CommandText = "select * from iusuario where Fecha = '" + tbfecha.Text + "' and Correo = '" + tbcorreo.Text + "' and Estado = 'True'";
            comand.Connection = conetion;
            adapter.SelectCommand = comand;
            adapter.Fill(daset, "iusuario");

            if (daset.Tables[i].Rows.Count > 0)
            {
                if (fecha == daset.Tables[i].Rows[i]["Fecha"].ToString() && correo == daset.Tables[i].Rows[i]["Correo"].ToString())
                {
                    SqlDataReader lector = comand.ExecuteReader();
                    if (lector.Read())
                    {
                        mostrar.Text = "Usuario: " + lector["Username"].ToString();
                        mostrarcontra.Text = "Contraeña: " + lector["Contraseña"].ToString();
                        
                    }
                    
                }
            }
            else
            {
                mostrar.Text = "El usuario no se encuentra disponible";
            }
        }
        protected void tbcorreo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}