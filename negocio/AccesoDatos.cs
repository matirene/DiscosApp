using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class AccesoDatos
    {
        //Atributos
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader reader;

        // Propiedades
        public SqlDataReader Reader 
        { 
            get { return reader; } 
        }

        //Constructor
        public AccesoDatos()
        {
            conexion = new SqlConnection("server=MATIAS-PC\\SQLEXPRESS; database=DISCOS_DB; integrated security=true;");
            comando = new SqlCommand();
        }

        public void setQuery(string query)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = query;
        }

        public void executeReader()
        {
            comando.Connection = conexion;

            try
            {
                conexion.Open();
                reader = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void executeAccion()
        {
            comando.Connection = conexion;

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void setParameters(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }
       
        public void closeConexion()
        {
            if(reader != null)
                reader.Close();

            conexion.Close();
        }

    }
}
