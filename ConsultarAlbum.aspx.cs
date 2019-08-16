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
    public partial class ConsultarAlbum : System.Web.UI.Page
    {

        String cadenadeconexion = "Data Source=DESKTOP-8D8GHSN\\SQLEXPRESS;Initial Catalog=RegistroIPC;Integrated Security=True";
        public string nombredelartista;
        public string datos;


        protected void Page_Load(object sender, EventArgs e)
        {

            //dato.Text = Request.QueryString["Id"];
            metodoconsultaralbum();

        }

        public void metodoconsultaralbum()
        {


            SqlConnection conexionsql = new SqlConnection(cadenadeconexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select ialbum.Titulo, ialbum.Foto FROM ialbum INNER JOIN zartista on ialbum.Idartista = zartista.IdArtista Where zartista.Nombre = '" + Request.QueryString["Id"] + "'";
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