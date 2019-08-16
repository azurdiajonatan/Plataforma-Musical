using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace IPC2Proyect1
{
    public class Paneles
    {
        private Panel Contenedor;
        public Label labelnumero;
        public Label labelnombre;
        public Label labelduracion;
        public ImageButton eliminacion;
        

        public Paneles()
        {
            Contenedor = new Panel();
            labelnumero = new Label();
            labelnombre = new Label();
            labelduracion = new Label();
            eliminacion = new ImageButton();

            eliminacion.CausesValidation = false;

            eliminacion.Height = 30;
            eliminacion.Width = 20;
            eliminacion.ImageUrl = "~/Imagenes/archivo.png";

            labelnumero.Height = 40;
            labelnumero.Width = 50;

            labelnombre.Height = 40;
            labelnombre.Width = 450;

            labelduracion.Height = 40;
            labelduracion.Width = 190;

            //tamano del contenedor
            Contenedor.Height = 50;
            Contenedor.Width = 900;
        }

        public Panel getPaneles()
        {

            Contenedor.Controls.Add(labelnumero);
            Contenedor.Controls.Add(labelnombre);
            Contenedor.Controls.Add(labelduracion);
            Contenedor.Controls.Add(eliminacion);

            return this.Contenedor;
        }


    }
}