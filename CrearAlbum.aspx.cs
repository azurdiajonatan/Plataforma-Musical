using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Collections;

namespace IPC2Proyect1
{
    public partial class CrearAlbum : System.Web.UI.Page
    {
      
        public string nombrearchivo;
        public string nombrefoto;
        DataTable tablas = new DataTable();

        SqlCommand cd = new SqlCommand();
        SqlConnection conet = new SqlConnection();
        SqlDataAdapter adap = new SqlDataAdapter();
        DataSet ds = new DataSet();
        string cadena = "Data Source=DESKTOP-8D8GHSN\\SQLEXPRESS;Initial Catalog=RegistroIPC;Integrated Security=True";
        public int codigoartista;
        public Boolean estadoinicial = true;

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-8D8GHSN\\SQLEXPRESS;Initial Catalog=RegistroIPC;Integrated Security=True");

        

        //listas
        static int numerodecancion;
        static ArrayList arreglodecanciones = new ArrayList();
        

        protected void Page_Load(object sender, EventArgs e)
        {
            idartista.Text = Session["Clave"].ToString();

        }

        protected void bcancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomeArtista.aspx");
        }

        protected void banadir_Click(object sender, EventArgs e)
        {

            try
            {
                if (FileUpload2.HasFile)
                {


                    nombrearchivo = FileUpload2.FileName;
                    string ruta = "~/Canciones/" + nombrearchivo;
                    FileUpload2.SaveAs(Server.MapPath(ruta));



                }
                else { }
            }
            catch (Exception ios)
            {

            }
 
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }




        protected void bfinalizar_Click(object sender, EventArgs e)
        {



            string consulta = "Select * From zartista where Nombre = '" + Session["Artista"].ToString() + "'";
            SqlCommand com = new SqlCommand(consulta, con);
            con.Open();
            SqlDataReader leer = com.ExecuteReader();

            if (leer.Read() == true)
            {
                idartista.Text = leer["IdArtista"].ToString();
            }
            con.Close();

            codigoartista = Convert.ToInt32(idartista.Text); // esta variable guarda el codigo del artista



            int tamaño = FileUpload1.PostedFile.ContentLength;
            Byte[] ImagenOriginal = new byte[tamaño];

            FileUpload1.PostedFile.InputStream.Read(ImagenOriginal, 0, tamaño);
            Bitmap Imagensubidabin = new Bitmap(FileUpload1.PostedFile.InputStream);

            SqlConnection conexionasql = new SqlConnection(cadena);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "INSERT INTO ialbum(Titulo,Fecha,Reseña,Portada,Estado,Idartista,Foto) VALUES (@titulo,@fecha,@reseña,@portada,@estado,@artista,@foto)";
            comando.Parameters.Add("@titulo", SqlDbType.Text).Value = txtitulo.Text;
            comando.Parameters.Add("@fecha", SqlDbType.Text).Value = txfecha.Text;
            comando.Parameters.Add("@reseña", SqlDbType.Text).Value = txresena.Text;
            comando.Parameters.Add("@portada", SqlDbType.Image).Value = ImagenOriginal;
            comando.Parameters.Add("@estado", SqlDbType.Bit).Value = estadoinicial;
            comando.Parameters.Add("@artista", SqlDbType.Int).Value = codigoartista;

            if(FileUpload1.HasFile)
            {
                nombrefoto = FileUpload1.FileName;
                string ruta = "~/Portadas/" + nombrefoto;
                FileUpload1.SaveAs(Server.MapPath(ruta));
                comando.Parameters.Add("@foto", SqlDbType.Text).Value = ruta;
            }

            comando.CommandType = CommandType.Text;
            comando.Connection = conexionasql;
            conexionasql.Open();
            comando.ExecuteNonQuery();



        }
    }
}