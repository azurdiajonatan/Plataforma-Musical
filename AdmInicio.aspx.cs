using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IPC2Proyect1
{
    public partial class AdmInicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void tbusuario_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("GestionUsuarios.aspx");
        }

        protected void tbregistrousuario_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("ConsultarUsuarios.aspx");
        }

        protected void tbmusica_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("AgregarGenero.aspx");
        }

        protected void tbeliminados_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("ArtistasEliminados.aspx");
        }

        protected void tbarchivos_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("AlbumEliminado.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("CerrarSesion.aspx");
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("CrearNoticia.aspx");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Reportes.aspx");
        }
    }
}