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
    public partial class GestionUsuarios : System.Web.UI.Page
    {
        SqlCommand cd;
        SqlConnection conet = new SqlConnection();
        SqlDataAdapter adap;
        DataSet ds = new DataSet();
        string str = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            conet.ConnectionString = "Data Source=DESKTOP-8D8GHSN\\SQLEXPRESS;Initial Catalog=RegistroIPC;Integrated Security=True";
           
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void tbcrear_Click(object sender, EventArgs e)
        {

            conet.Open();
            str = "select * from iusuario where Username = '" + txusuario.Text + "'";
            cd = new SqlCommand(str,conet);
            int contador = Convert.ToInt32(cd.ExecuteScalar());
            conet.Close();

            if(contador > 0)
            {
              Advertencia.Text = "Este usuario ya existe";
              
            }
            else
            {
               Informacion.Text = "Usuario Aceptado";
                Cnusuario nuevo = new Cnusuario(0, "", "", "", "", "", "", "", true);
                string obtenercaja = tltipo.SelectedItem.ToString();

                    nuevo.nombre = txnombre.Text;
                    nuevo.username = txusuario.Text;              
                    nuevo.correo = txcorreo.Text;
                    nuevo.fecha = txfecha.Text;
                    nuevo.creafecha = DateTime.Now.ToString("dd/MM/yyyy");
                    nuevo.tipo = obtenercaja;
                if (rbactivo.Checked == true)
                {
                    nuevo.Estado = true;
                }
                else if (rbdesactivado.Checked == true)
                {
                    nuevo.Estado = false;
                }
                nuevo.Agregar();
                Informacion.Text = "Se Agrego un nuevo usuario";
                Advertencia.Text = "";
                

            }

        }

        protected void tbcancelar_Click(object sender, EventArgs e)
        {
          
            if (txnombre.Text == "hola")
            {
                Informacion.Text = "los if funcionan";
            }
            else
            {
                Informacion.Text = "no funcionan los if";
            }
        }

        protected void tbregresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdmInicio.aspx");
        }

        protected void tbmodificar_Click(object sender, EventArgs e)
        {


            Cnusuario nuevo = new Cnusuario(0, "", "", "", "", "", "", "", true);
            string obtenercaja = tltipo.SelectedItem.ToString();

           
                nuevo.nombre = txnombre.Text;
                nuevo.username = txusuario.Text;
                nuevo.correo = txcorreo.Text;
                nuevo.fecha = txfecha.Text;
                nuevo.contraseña = txcontraseña.Text;
                nuevo.creafecha = DateTime.Now.ToString("dd/MM/yyyy");
                nuevo.tipo = obtenercaja;
                if (rbactivo.Checked == true)
                {
                    nuevo.Estado = true;
                }
                else if (rbdesactivado.Checked == true)
                {
                    nuevo.Estado = false;
                }

                nuevo.Modificar();
                Informacion.Text = "Registro Actualizado";
            
            
        }

        protected void tbeliminar_Click(object sender, EventArgs e)
        {

            Cnusuario nuevo = new Cnusuario(0, "", "", "", "", "", "", "", true);
            nuevo.eliminar(int.Parse(txbuscar.Text.Trim()));
            Informacion.Text = "Registro eliminado";
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void tbbuscar_Click(object sender, EventArgs e)
        {
            tbmodificar.Enabled = true;
            tbeliminar.Enabled = true;
            Cnusuario nuevo = new Cnusuario(0, "", "", "", "", "", "", "", true);
            if (nuevo.Verificacion(int.Parse(txbuscar.Text.Trim())))
            {
                txnombre.Text = nuevo.nombre;
                txusuario.Text = nuevo.username;
                txcontraseña.Text = nuevo.contraseña;
                txcorreo.Text = nuevo.correo;
                txfecha.Text = nuevo.fecha;

                if (nuevo.Estado == true)
                {
                    rbactivo.Checked = true;
                }
                else if (nuevo.Estado == true)
                {

                    rbactivo.Checked = false;
                }
            }
            

        }
    }
}