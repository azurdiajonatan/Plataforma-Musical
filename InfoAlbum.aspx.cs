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
    public partial class InfoAlbum : System.Web.UI.Page
    {
        String cadenadeconexion = "Data Source=DESKTOP-8D8GHSN\\SQLEXPRESS;Initial Catalog=RegistroIPC;Integrated Security=True";

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-8D8GHSN\\SQLEXPRESS;Initial Catalog=RegistroIPC;Integrated Security=True");

        public string codigodealbum;
        public string codigodecancion;

        protected void Page_Load(object sender, EventArgs e)
        {
            informacion();
            mostrarcomentarios();
            mostrarimagen();
        }

        public void mostrarimagen()
        {
            string consulta = "Select Foto From ialbum where Titulo = '" + Request.QueryString["Id"] + "'";
            SqlCommand com = new SqlCommand(consulta, con);
            con.Open();
            SqlDataReader leer = com.ExecuteReader();

            if (leer.Read() == true)
            {
               img.ImageUrl = leer["Foto"].ToString();
            }
            con.Close();
        }

        public void informacion()
        {

            SqlConnection conexionsql = new SqlConnection(cadenadeconexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select icancion.Nombre, icancion.Duracion, icancion.Cancion FROM icancion INNER JOIN ialbum on icancion.idalbum = ialbum.Idalbum Where ialbum.Titulo = '" + Request.QueryString["Id"] + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexionsql;
            conexionsql.Open();


            DataTable imagenesbotones = new DataTable();
            imagenesbotones.Load(cmd.ExecuteReader());
            Repeater1.DataSource = imagenesbotones;
            Repeater1.DataBind();
            conexionsql.Close();
            

        }


        public void mostrarcomentarios()
        {

            SqlConnection conexionsql = new SqlConnection(cadenadeconexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select icomentario.Comentario FROM icomentario INNER JOIN ialbum on icomentario.enlacealbum = ialbum.Idalbum where ialbum.Titulo = '" + Request.QueryString["Id"] + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexionsql;
            conexionsql.Open();
            DataTable imagenesbotones = new DataTable();
            imagenesbotones.Load(cmd.ExecuteReader());
            Repeater2.DataSource = imagenesbotones;
            Repeater2.DataBind();
            conexionsql.Close();
            


        }

        protected void botonagregar_Click(object sender, EventArgs e)
        {

            string consulta = "Select Idalbum From ialbum where Titulo = '" + Request.QueryString["Id"] + "'";
            SqlCommand com = new SqlCommand(consulta, con);
            con.Open();
            SqlDataReader leer = com.ExecuteReader();

            if (leer.Read() == true)
            {
                codigodealbum = leer["Idalbum"].ToString();
            }
            con.Close();



            SqlConnection conexionasql = new SqlConnection(cadenadeconexion);
            SqlCommand comando = new SqlCommand();
            SqlCommand comandoconsulta = new SqlCommand();

            string comentario = "Desconocido";


            comando.CommandText = "INSERT INTO icomentario (Nombre,Comentario,enlacealbum) VALUES (@nombre,@comentario,@codigo)";
            comando.Parameters.Add("@nombre", SqlDbType.Text).Value = comentario;
            comando.Parameters.Add("@comentario", SqlDbType.Text).Value = txcomentario.Text;
            comando.Parameters.Add("@codigo", SqlDbType.Int).Value = codigodealbum ;
            comando.CommandType = CommandType.Text;
            comando.Connection = conexionasql;
            conexionasql.Open();
            comando.ExecuteNonQuery();
            conexionasql.Close();

            Validar.Text = "Se agrego el comentario";


            txcomentario.Text = "";

        }

        protected void Reproducir_Click(object sender, EventArgs e)
        {
            string consulta = "Select icancion.Cancion From icancion INNER JOIN ialbum on icancion.idalbum = ialbum.Idalbum where ialbum.Titulo = '" + Request.QueryString["Id"] + "'";
            SqlCommand com = new SqlCommand(consulta, con);
            con.Open();
            SqlDataReader leer = com.ExecuteReader();

            if (leer.Read() == true)
            {
                codigodecancion = leer["Cancion"].ToString();
               // repro.Src = codigodecancion.ToString();
            }
            con.Close();


         

        }

        protected void Megusta_Click(object sender, EventArgs e)
        {

        }

        protected void Favoritos_Click(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            con.Open();
            string actualizar = "UPDATE ialbum SET Megusta = Megusta+1  where Titulo = '" + Request.QueryString["Id"] + "'";
            SqlCommand nuevocomando = new SqlCommand(actualizar, con);
            nuevocomando.ExecuteNonQuery();
            nuevocomando.Dispose();
            con.Close();



        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            con.Open();
            string actualizar = "UPDATE ialbum SET ContFavorito = ContFavorito+1 where Titulo = '" + Request.QueryString["Id"] + "'";
            SqlCommand nuevocomando = new SqlCommand(actualizar, con);
            nuevocomando.ExecuteNonQuery();
            nuevocomando.Dispose();
            con.Close();
        }
    }
}