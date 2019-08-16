using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;

namespace IPC2Proyect1
{
    public partial class AgregarGenero : System.Web.UI.Page
    {

        SqlCommand cd = new SqlCommand();
        SqlConnection conet = new SqlConnection();
        SqlDataAdapter adap = new SqlDataAdapter();
        DataSet ds = new DataSet();
        string cadena = "Data Source=DESKTOP-8D8GHSN\\SQLEXPRESS;Initial Catalog=RegistroIPC;Integrated Security=True";

      
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void tbhome_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdmInicio.aspx");
        }

        protected void tbnuevo_Click(object sender, EventArgs e)
        {

            //try
            //{
            //    string genero = txgenero.Text.Trim();
            //    int i = 0;
            //    cd.CommandText = "select * from igenero where Nombre = '" + txgenero.Text + "'";
            //    cd.Connection = conet;
            //    adap.SelectCommand = cd;
            //    adap.Fill(ds, "pruebagenero");

            //    if (ds.Tables[i].Rows.Count > 0)
            //    {
            //        if (genero == ds.Tables[i].Rows[i]["Nombre"].ToString())
            //        {
            //            mostrar.Text = "este genero ya existe";


            //        }
            //    }
            //    else
            //    {



            //    }
            //}
            //catch (Exception ios)
            //{
            //    advertencia.Text = "Porfavor ingrese datos";
            //}


            int tamaño = FileUpload1.PostedFile.ContentLength;
            Byte[] ImagenOriginal = new byte[tamaño];

            FileUpload1.PostedFile.InputStream.Read(ImagenOriginal, 0, tamaño);
            Bitmap Imagensubidabin = new Bitmap(FileUpload1.PostedFile.InputStream);

            SqlConnection conexionasql = new SqlConnection(cadena);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "INSERT INTO Agenero(Nombre,Imagen) VALUES (@nombre,@imagen)";
            comando.Parameters.Add("@nombre", SqlDbType.Text).Value = txgenero.Text;
            comando.Parameters.Add("@imagen", SqlDbType.Image).Value = ImagenOriginal;
            comando.CommandType = CommandType.Text;
            comando.Connection = conexionasql;
            conexionasql.Open();
            comando.ExecuteNonQuery();


        }



        protected void tbsubir_Click(object sender, EventArgs e)
        {      

        }

    }
}