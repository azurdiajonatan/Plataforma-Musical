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
    public partial class CrearNoticia : System.Web.UI.Page
    {

        SqlCommand cd = new SqlCommand();
        SqlConnection conet = new SqlConnection();
        SqlDataAdapter adap = new SqlDataAdapter();
        DataSet ds = new DataSet();
        string cadena = "Data Source=DESKTOP-8D8GHSN\\SQLEXPRESS;Initial Catalog=RegistroIPC;Integrated Security=True";
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-8D8GHSN\\SQLEXPRESS;Initial Catalog=RegistroIPC;Integrated Security=True");

        public String objetotitulo;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void tbagregar_Click(object sender, EventArgs e)
        {


            int tamaño = FileUpload1.PostedFile.ContentLength;
            Byte[] ImagenOriginal = new byte[tamaño];

            FileUpload1.PostedFile.InputStream.Read(ImagenOriginal, 0, tamaño);
            Bitmap Imagensubidabin = new Bitmap(FileUpload1.PostedFile.InputStream);

            SqlConnection conexionasql = new SqlConnection(cadena);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "INSERT INTO inoticia(Titulo,Imagen,Descripcion) VALUES (@titulo,@imagen,@descripcion)";
            comando.Parameters.Add("@titulo", SqlDbType.Text).Value = txtitulo.Text;
            comando.Parameters.Add("@imagen", SqlDbType.Image).Value = ImagenOriginal;
            comando.Parameters.Add("@descripcion", SqlDbType.Text).Value = txdescripcion.Text;
            comando.CommandType = CommandType.Text;
            comando.Connection = conexionasql;
            conexionasql.Open();
            comando.ExecuteNonQuery();


            Mensaje.Text = "Noticia Agregada con exito";
            limpiar();
        }

        protected void tbcancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdmInicio.aspx");
        }


        public void limpiar()
        {

            txtitulo.Text = "";
            txdescripcion.Text = "";

        }

        protected void botonmodificar_Click(object sender, EventArgs e)
        {

            con.Open();
            string actualizar = "UPDATE inoticia SET Titulo = '" + txtitulo.Text + "' , Descripcion = '" + txdescripcion.Text + "' Where Idnoticia = '" + tbbuscar.Text + "'";
            SqlCommand nuevocomando = new SqlCommand(actualizar, con);
            nuevocomando.ExecuteNonQuery();
            nuevocomando.Dispose();
            con.Close();
            Verificador.Text = "Se modifico el registro con exito";
            Response.Redirect("CrearNoticia.aspx");
            limpiador();


        }

        protected void botonbuscar_Click(object sender, EventArgs e)
        {
            string consulta = "Select * From  inoticia where Idnoticia = '" + tbbuscar.Text  + "'";
            SqlCommand com = new SqlCommand(consulta, con);
            con.Open();
            SqlDataReader leer = com.ExecuteReader();

            if (leer.Read() == true)
            {
  
                txtitulo.Text = leer["Titulo"].ToString();
                txdescripcion.Text = leer["Descripcion"].ToString();
                objetotitulo = txtitulo.Text;
                Session["Noticia"] = objetotitulo;


                
            }
            con.Close();

       
            botonmodificar.Enabled = true;
            botoneliminar.Enabled = true;

        }

        protected void botoneliminar_Click(object sender, EventArgs e)
        {

            con.Open();
            string actualizar = "DELETE FROM  inoticia WHERE Idnoticia = '" + tbbuscar.Text + "'";
            SqlCommand nuevocomando = new SqlCommand(actualizar, con);
            nuevocomando.ExecuteNonQuery();
            nuevocomando.Dispose();
            con.Close();
            Verificador.Text = "Se elimino el registro con exito";
            Response.Redirect("CrearNoticia.aspx");
            limpiador();

        }

        public void limpiador()
        {

            txtitulo.Text = "";
            txdescripcion.Text = "";
            tbbuscar.Text = "";

        }

    }
}