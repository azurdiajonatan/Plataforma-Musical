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
    public partial class ArtistasInfluyentes : System.Web.UI.Page
    {

        String cadenadeconexion = "Data Source=DESKTOP-8D8GHSN\\SQLEXPRESS;Initial Catalog=RegistroIPC;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            modulodeconsulta();
        }

        public void modulodeconsulta()
        {

            SqlConnection conexionsql = new SqlConnection(cadenadeconexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT TOP (10) Nombre, Megusta, Fotografia, Foto FROM zartista ORDER BY Megusta DESC";
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