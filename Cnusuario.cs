using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
namespace IPC2Proyect1
{

    public class Cnusuario : ConexionBD
    {
        String tabla = "iusuario"; //nombre de la tabla a utilizar
        protected string Nombre, Username, Contraseña, Correo, Tipo, Fecha, CreaFecha;
        protected DateTime fechadato;
        protected int id_Usuario;
        protected bool estado;
        public string mensaje;
        public Cnusuario(int id_Usuario, string Nombre, string Username, string Contraseña, string Correo, string Fecha, string CreaFecha, string Tipo, bool estado)
        {
            this.id_Usuario = id_Usuario;
            this.Nombre = Nombre;
            this.Username = Username;
            this.Contraseña = Contraseña;
            this.Correo = Correo;
            this.Fecha = Fecha;
            this.CreaFecha = CreaFecha;
            this.Tipo = Tipo;
            this.estado = estado;
        }

        //metodos para ingresar y recuperar informacion

        public int id_usuario
        {
            set { id_Usuario = value; }
            get { return id_Usuario; }
        }

        public String nombre
        {
            set { Nombre = value; }
            get { return Nombre; }

        }

        public String username
        {
            set { Username = value; }
            get { return Username; }

        }

        public String contraseña
        {
            set { Contraseña = value; }
            get { return Contraseña; }

        }

        public String correo
        {
            set { Correo = value; }
            get { return Correo; }

        }

        public String tipo
        {
            set { Tipo = value; }
            get { return Tipo; }

        }

        public Boolean Estado
        {
            set { estado = value; }
            get { return estado; }

        }

        public String fecha
        {
            set { Fecha = value; }
            get { return Fecha; }

        }

        public String creafecha
        {
            set { CreaFecha = value; }
            get { return CreaFecha; }

        }



        //metodo para registrar
        public void Agregar()
        {
            Conectar(tabla);
            DataRow fila;
            fila = Data.Tables[tabla].NewRow();
            fila["id_Usuario"] = id_usuario;
            fila["Nombre"] = nombre;
            fila["Username"] = username;
            fila["Contraseña"] = contraseña;
            fila["Correo"] = correo;
            fila["Fecha"] = fecha;
            fila["CreaFecha"] = creafecha;
            fila["Tipo"] = tipo;
            fila["Estado"] = estado;

            Data.Tables[tabla].Rows.Add(fila);
            AdaptadordeDatos.Update(Data, tabla);

        }

        //metodo para agregar 2 verificacion incluida

        public void Verificacionyagregar(string usuarios, string correos)
        {
            Conectar(tabla);
            DataRow fila;

            int x = Data.Tables[tabla].Rows.Count - 1;
            for (int i = 0; i <= x; i++)
            {
                fila = Data.Tables[tabla].Rows[i];
                if (fila["Username"].ToString() == usuarios || fila["Correo"].ToString() == correos)
                {
                    mensaje = "Este usuario ya existe";
                  
                }
                else
                {
                    fila = Data.Tables[tabla].NewRow();
                    fila["id_Usuario"] = id_usuario;
                    fila["Nombre"] = nombre;
                    fila["Username"] = username;
                    fila["Contraseña"] = contraseña;
                    fila["Correo"] = correo;
                    fila["Fecha"] = fecha;
                    fila["CreaFecha"] = creafecha;
                    fila["Tipo"] = tipo;
                    fila["Estado"] = estado;
                    Data.Tables[tabla].Rows.Add(fila);
                    AdaptadordeDatos.Update(Data, tabla);
                }
            }
        }


        // modificar
        public void Modificar()
        {
            Conectar(tabla);
            DataRow fila;
            int x = Data.Tables[tabla].Rows.Count - 1;
            for (int i = 0; i <= x; i++)
            {
                fila = Data.Tables[tabla].Rows[i];
                
                if (fila["Username"].ToString().Trim() == username)
                {
                    fila["id_Usuario"] = id_usuario;
                    fila["Nombre"] = nombre;
                    fila["Username"] = username;
                    fila["Contraseña"] = contraseña;
                    fila["Correo"] = correo;
                    fila["Fecha"] = fecha;
                    fila["Tipo"] = tipo;
                    fila["Estado"] = estado;
                    AdaptadordeDatos.Update(data, tabla);
                }
            }
        }

        public bool Verificacion(int valor)
        {
            Conectar(tabla);
            DataRow fila;

            int x = Data.Tables[tabla].Rows.Count - 1;
            for (int i = 0; i <= x; i++)
            {
                fila = Data.Tables[tabla].Rows[i];
                if (int.Parse(fila["id_Usuario"].ToString()) == valor)
                {
                    id_usuario = int.Parse(fila["id_Usuario"].ToString());
                    nombre = fila["Nombre"].ToString();
                    username = fila["Username"].ToString();
                    contraseña = fila["Contraseña"].ToString();
                    correo = fila["Correo"].ToString();
                    fecha = fila["Fecha"].ToString();
                    tipo = fila["Tipo"].ToString();
                    estado = bool.Parse(fila["Estado"].ToString());
                    AdaptadordeDatos.Update(data, tabla);
                    return true;
                }
            }
            return false;
        }

        public bool eliminar(int valor)
        {
            Conectar(tabla);
            DataRow fila;

            int x = Data.Tables[tabla].Rows.Count - 1;
            for (int i = 0; i <= x; i++)
            {
                fila = Data.Tables[tabla].Rows[i];
                if (int.Parse(fila["id_Usuario"].ToString()) == valor)
                {
                    fila = Data.Tables[tabla].Rows[i];
                    fila.Delete();

                    DataTable datoseliminados;
                    datoseliminados = Data.Tables[tabla].GetChanges(DataRowState.Deleted);
                    Data.Tables[tabla].AcceptChanges();
                    AdaptadordeDatos.Update(datoseliminados);

                    return true;
                }
            }
            return false;

        }
    }
}