using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace IPC2Proyect1
{
    public class ConexionBD
    {
        protected SqlDataReader reader;
        protected SqlDataAdapter AdaptadordeDatos;
        protected DataSet data;
        protected SqlConnection conexion = new SqlConnection();


        public ConexionBD()
        {


        }

        public void Conectar(string tabla)
        {
            string strConexion = ConfigurationManager.ConnectionStrings["RegistroIPCConnectionString"].ConnectionString;
            conexion.ConnectionString = strConexion;
            conexion.Open();
            AdaptadordeDatos = new SqlDataAdapter("select * from " + tabla,conexion);
            SqlCommandBuilder ejecutar = new SqlCommandBuilder(AdaptadordeDatos);
            Data = new DataSet();
            AdaptadordeDatos.Fill(Data, tabla);
            conexion.Close();
        }

        public DataSet Data
        {
            set { data = value; }
            get { return data; }
        }

        public SqlDataReader DataRead
        {
            set { reader = value; }
            get { return  reader; }
        }
    }
}