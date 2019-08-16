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
    public partial class Generos : System.Web.UI.Page
    {
        String cadenadeconexion = "Data Source=DESKTOP-8D8GHSN\\SQLEXPRESS;Initial Catalog=RegistroIPC;Integrated Security=True";
        public string sesiongenero;
        protected void Page_Load(object sender, EventArgs e)
        {
            ConsultarImagen();
        }

        protected void ConsultarImagen()
        {
            SqlConnection conexionsql = new SqlConnection(cadenadeconexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT Imagen,Nombre FROM Agenero ORDER BY id_genero ASC";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexionsql;


            //conexionsql.Open();
            //SqlDataReader leer = cmd.ExecuteReader();

            //if (leer.Read() == true)
            //{
            //    sesiongenero = leer["Nombre"].ToString();
            //    Session["Genero"] = sesiongenero;
            //}
            //conexionsql.Close();


            conexionsql.Open();
           
            DataTable imagenesbotones = new DataTable();
            imagenesbotones.Load(cmd.ExecuteReader());

            Repeater1.DataSource = imagenesbotones;
            Repeater1.DataBind();
            conexionsql.Close();

      

        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }
    }
}