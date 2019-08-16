using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace IPC2Proyect1
{
    public class Conexion2BD
    {

        protected SqlDataReader readerdos;
        protected SqlDataAdapter AdaptadordeDatosdos;
        protected DataSet datados;
        protected SqlConnection conexiondos = new SqlConnection();


        public Conexion2BD()
        {

        }


        public void Conectar(string tablados)
        {
            string strConexion = ConfigurationManager.ConnectionStrings["RegistroIPCConnectionString"].ConnectionString;
            conexiondos.ConnectionString = strConexion;
            conexiondos.Open();
            AdaptadordeDatosdos = new SqlDataAdapter("select * from " + tablados, conexiondos);
            SqlCommandBuilder ejecutar = new SqlCommandBuilder(AdaptadordeDatosdos);
            Datados = new DataSet();
            AdaptadordeDatosdos.Fill(Datados, tablados);
            conexiondos.Close();
        }

        public DataSet Datados
        {
            set { datados = value; }
            get { return datados; }
        }

        public SqlDataReader DataReaddos
        {
            set { readerdos = value; }
            get { return readerdos; }
        }
    }

}

    
