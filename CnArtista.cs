using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IPC2Proyect1
{
    public class CnArtista : Conexion2BD
    {

        String tabla = "zartista"; //nombre de la tabla a utilizar
        protected string Nombre, Fecha, Fotografia, Descripcion, Eliminado;
        protected int Megusta,enlacepais;
        protected string Paginaweb, Facebook,Twitter,Youtube;
      
        public CnArtista(string Nombre, string Fechaf, string Descripcion, string Fotografia, string Fechael,string Paginaweb,string Facebook,string Twitter,string Youtube)
        {

            this.Nombre = Nombre;
            this.Nombre = Nombre;
            this.Nombre = Nombre;
            this.Nombre = Nombre;
            this.Nombre = Nombre;
            this.Nombre = Nombre;
            this.Nombre = Nombre;
            this.Nombre = Nombre;


        }
    }
}