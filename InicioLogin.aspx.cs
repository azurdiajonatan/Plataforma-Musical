using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace IPC2Proyect1
{
    public partial class InicioLogin : System.Web.UI.Page
    {
        SqlCommand cd = new SqlCommand();
        SqlConnection conet = new SqlConnection();
        SqlDataAdapter adap = new SqlDataAdapter();
        DataSet ds = new DataSet();

        string cadena = "Data Source=DESKTOP-8D8GHSN\\SQLEXPRESS;Initial Catalog=RegistroIPC;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {

            conet.ConnectionString = "Data Source=DESKTOP-8D8GHSN\\SQLEXPRESS;Initial Catalog=RegistroIPC;Integrated Security=True";
            conet.Open();

        //    try
        //    {
        //        Bases.DataUserTableAdapters.iusuarioTableAdapter obj = new Bases.DataUserTableAdapters.iusuarioTableAdapter();
        //        String Nombreusuario = obj.ELogin(tbusuario.Text, txcontraseña.Text).ToString();
        //        if (!Nombreusuario.Equals(""))
        //        {
        //            Session["Usuarios"] = Nombreusuario;
        //            Response.Redirect("Home.aspx");
        //        }
        //    }
        //    catch (Exception ios)
        //    {
        //        Mensaje.Text = "Usuario/Contraseña Incorrectos";
        //    }

        }

        protected void tbregitrarse_Click(object sender, EventArgs e)
        {
            Response.Redirect("InicioRegistrar.aspx");
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void tbIngresar_Click(object sender, EventArgs e)
        {

            string password = txcontraseña.Text.Trim();
            int i = 0;
            cd.CommandText = "select * from iusuario where Username = '" + tbusuario.Text + "' and Contraseña = '"  + txcontraseña.Text +"' and Estado = 'True'" ;
            cd.Connection = conet;
            adap.SelectCommand = cd;
            adap.Fill(ds, "iusuario");
            if (tbusuario.Text == "Admin" && txcontraseña.Text == "amd1") {
                Response.Redirect("AdmInicio.aspx");
            }
            else
            {
                if (ds.Tables[i].Rows.Count > 0)
                {
                    if (password == ds.Tables[i].Rows[i]["Contraseña"].ToString())
                    {
                        Session["Usuarios"] = tbusuario.Text;
                        if ("" == ds.Tables[i].Rows[i]["id_Artista"].ToString())
                        {
                            Response.Redirect("Home.aspx");
                        }
                        else
                        {
                            SqlConnection con = new SqlConnection("Data Source=DESKTOP-8D8GHSN\\SQLEXPRESS;Initial Catalog=RegistroIPC;Integrated Security=True");
                            string consulta = "Select id_Artista From iusuario where Username = '" + tbusuario.Text + "'";
                            SqlCommand com = new SqlCommand(consulta, con);
                            con.Open();
                            SqlDataReader leer = com.ExecuteReader();

                            if (leer.Read() == true)
                            {
                                string clavedeartista = leer["id_Artista"].ToString();
                                Session["Clave"] = clavedeartista;
                            }
                            con.Close();
                            Response.Redirect("HomeArtista.aspx");

                        }
                    }
                    else
                    {
                        Mensaje.Text = "Usuario no encontrado";
                   }
                }
            }
        
            

        }

        protected void tbusuario_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txcontraseña_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //int tamaño = FileUpload1.PostedFile.ContentLength;
            //Byte[] ImagenOriginal = new byte[tamaño];

            //FileUpload1.PostedFile.InputStream.Read(ImagenOriginal, 0, tamaño);
            //Bitmap Imagensubidabin = new Bitmap(FileUpload1.PostedFile.InputStream);

            //SqlConnection conexionasql = new SqlConnection(cadena);
            //SqlCommand comando = new SqlCommand();
            //comando.CommandText = "UPDATE zartista Set Fotografia = '" + ImagenOriginal + "' Where IdArtista = 23";
            //comando.CommandType = CommandType.Text;
            //comando.Connection = conexionasql;
            //conexionasql.Open();
            //comando.ExecuteNonQuery();
        }
    }
}