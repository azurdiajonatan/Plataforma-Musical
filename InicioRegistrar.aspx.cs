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
    public partial class InicioRegistrar : System.Web.UI.Page
    {

        SqlCommand cd;
        SqlConnection conet = new SqlConnection();
        SqlDataAdapter adap;
        DataSet ds = new DataSet();
        string str = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            conet.ConnectionString = "Data Source=DESKTOP-8D8GHSN\\SQLEXPRESS;Initial Catalog=RegistroIPC;Integrated Security=True";
        }

        protected void tbaceptar_Click(object sender, EventArgs e)
        {

            conet.Open();
            str = "select * from iusuario where Username = '" + txusuario.Text + "'";
            cd = new SqlCommand(str, conet);
            int contador = Convert.ToInt32(cd.ExecuteScalar());
            conet.Close();

            if (contador > 0)
            {
                mensajeador.Text = "El nombre del usuario ya existe";

            }
            else
            {

                String usuariotipo = "Usuario";
                Cnusuario nuevo = new Cnusuario(0, "", "", "", "", "", "", "", true);
                if (txnombre.Text.Equals("") || txusuario.Text.Equals("") || txcontraseñaing.Text.Equals("") || txcorreoelec.Text.Equals("") || txfechadenacimiento.Text.Equals(""))
                {

                    mensajeador.Text = "Ingrese por favor toda la información solicitada";
                }
                else
                {
                    nuevo.nombre = txnombre.Text;
                    nuevo.username = txusuario.Text;
                    if (txcontraseñaing.Text == txconfirmar.Text)
                    {
                        nuevo.contraseña = txcontraseñaing.Text;
                    }
                    else
                    {
                        mensajeador.Text = "Verifique la contraseña";
                    }
                    nuevo.correo = txcorreoelec.Text;
                    nuevo.fecha = txfechadenacimiento.Text;
                    nuevo.creafecha = DateTime.Now.ToString("dd/MM/yyyy");
                    nuevo.tipo = usuariotipo;
                    nuevo.Estado = true;
                    nuevo.Agregar();
                    Session["Usuarios"] = txusuario.Text;
                    Response.Redirect("Home.aspx");
                    mensajeador.Text = "Se Agrego un nuevo usuario";
                }


            }









        }

        protected void tbregresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("InicioLogin.aspx");
        }
    }
}