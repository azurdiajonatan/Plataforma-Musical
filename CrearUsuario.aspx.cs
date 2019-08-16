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
    public partial class CrearUsuario : System.Web.UI.Page
    {

        SqlCommand cd;
        SqlConnection conet = new SqlConnection();
        SqlDataAdapter adap;
        DataSet ds = new DataSet();
        string str = null;
        string cadenadeconexion = "Data Source=DESKTOP-8D8GHSN\\SQLEXPRESS;Initial Catalog=RegistroIPC;Integrated Security=True";
        public int codigoartista;

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-8D8GHSN\\SQLEXPRESS;Initial Catalog=RegistroIPC;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void tbsubir_Click(object sender, EventArgs e)
        {

        }

        protected void tbactualizar_Click(object sender, EventArgs e)
        {

            string obtenerfecha = dropano.SelectedItem.ToString();
            int indicepais = droppais.SelectedIndex + 1;
            int indicegenero = dropgenero.SelectedIndex + 1;
    

            int tamaño = FileUpload1.PostedFile.ContentLength;
            Byte[] ImagenOriginal = new byte[tamaño];

            FileUpload1.PostedFile.InputStream.Read(ImagenOriginal, 0, tamaño);
            Bitmap Imagensubidabin = new Bitmap(FileUpload1.PostedFile.InputStream);

            SqlConnection conexionasql = new SqlConnection(cadenadeconexion);
            SqlCommand comando = new SqlCommand();
            SqlCommand comandoconsulta = new SqlCommand();


            comando.CommandText = "INSERT INTO zartista(Nombre,Fecha,Fotografia,Descripcion,Paginaweb,Facebook,Twitter,Youtube,enlacepais) VALUES (@nombre,@fecha,@fotografia,@descripcion,@pagina,@facebook,@twitter,@youtube,@enlace)";    
            comando.Parameters.Add("@nombre", SqlDbType.Text).Value = txnombre.Text;
            comando.Parameters.Add("@fecha", SqlDbType.Text).Value = obtenerfecha;
            comando.Parameters.Add("@fotografia", SqlDbType.Image).Value = ImagenOriginal;
            comando.Parameters.Add("@descripcion", SqlDbType.Text).Value = cajadescripcion.Text;
            comando.Parameters.Add("@pagina", SqlDbType.Text).Value = txweb.Text;
            comando.Parameters.Add("@facebook", SqlDbType.Text).Value = txfacebook.Text;
            comando.Parameters.Add("@twitter", SqlDbType.Text).Value = txtwitter.Text;
            comando.Parameters.Add("@youtube", SqlDbType.Text).Value = txyoutube.Text;
            comando.Parameters.Add("@enlace", SqlDbType.Int).Value = indicepais;

            comando.CommandType = CommandType.Text;
            comando.Connection = conexionasql;
            conexionasql.Open();
            comando.ExecuteNonQuery();
            Session["Artista"] = txnombre.Text; //nombre del artista lo tomamos aqui
            conexionasql.Close();


            string consulta = "Select * From zartista where Nombre = '" + Session["Artista"].ToString() + "'";
            SqlCommand com = new SqlCommand(consulta,con);
            con.Open();
            SqlDataReader leer = com.ExecuteReader();

            if (leer.Read() == true)
            {
                idartista.Text = leer["IdArtista"].ToString(); 
            }
            con.Close();

            codigoartista = Convert.ToInt32(idartista.Text);
            Advertencia.Text = codigoartista.ToString();
            Session["Codigos"] = codigoartista; //tomamos el id del artista justo aqui

            con.Open();
            string actualizar = "UPDATE iusuario SET id_Artista = '" + codigoartista + "' where Username = '" + Session["Usuarios"].ToString() + "'";
            SqlCommand nuevocomando = new SqlCommand(actualizar, con);
            nuevocomando.ExecuteNonQuery();
            nuevocomando.Dispose();
            con.Close();

            string insert = "INSERT INTO ArtistaGenero (EnlaceArtista,EnlaceGenero) VALUES (@artista,@genero)";
            con.Open();
            SqlCommand cmd = new SqlCommand(insert,con);
            cmd.Parameters.Add("@artista", SqlDbType.Int).Value = codigoartista;
            cmd.Parameters.Add("@genero", SqlDbType.Int).Value = indicegenero;
            cmd.ExecuteNonQuery();
            con.Close();

            Response.Redirect("HomeArtista.aspx");

        }

        protected void tbeliminar_Click(object sender, EventArgs e)
        {


        }
    }
}