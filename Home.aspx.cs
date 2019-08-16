using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IPC2Proyect1
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["Usuarios"].Equals(""))
            //{
            //    Response.Redirect("login.aspx");
            //}
            //else
            //{
            //    Response.Write(Session["Usuarios"].ToString());
            //}
        }

        protected void imagen1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Generos.aspx");
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("ArtistasInfluyentes.aspx");
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("AlbumesPopulares.aspx");
        }
    }
}