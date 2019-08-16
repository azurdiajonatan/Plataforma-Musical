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
    public partial class ConsultaporArtista : System.Web.UI.Page
    {
        String cadenadeconexion = "Data Source=DESKTOP-8D8GHSN\\SQLEXPRESS;Initial Catalog=RegistroIPC;Integrated Security=True";
        public string nombredelartista;
        public string datos;

        protected void Page_Load(object sender, EventArgs e)
        {


            metodoconsultar();

        }


        public void metodoconsultar()
        {

            //datos = Request.QueryString["Id"];
            //consultor.Text = datos;

            //string consulta = "Select * From zartista where Nombre = '" + Session["Artista"].ToString() + "'";
            //SqlCommand com = new SqlCommand(consulta, con);
            //con.Open();
            //SqlDataReader leer = com.ExecuteReader();

            //if (leer.Read() == true)
            //{
            //    idartista.Text = leer["IdArtista"].ToString();
            //}
            //con.Close();

            SqlConnection conexionsql = new SqlConnection(cadenadeconexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select zartista.Nombre, zartista.Foto From zartista INNER JOIN ArtistaGenero on zartista.IdArtista = ArtistaGenero.EnlaceArtista INNER JOIN Agenero on ArtistaGenero.EnlaceGenero = Agenero.id_Genero Where Agenero.Nombre = '" + Request.QueryString["Id"] + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexionsql;
            conexionsql.Open();
            DataTable imagenesbotones = new DataTable();
            imagenesbotones.Load(cmd.ExecuteReader());
            Repeater1.DataSource = imagenesbotones;
            Repeater1.DataBind();
            conexionsql.Close();

        }

    }
}