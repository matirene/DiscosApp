using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace discosApp
{
    internal class DiscoNegocio
    {
        // Metodos
        public List<Disco> listar()
        {
            List<Disco> lista = new List<Disco>();

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=MATIAS-PC\\SQLEXPRESS; database=DISCOS_DB; integrated security=true;";

                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select D.Id, Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, E.Descripcion as Estilo, TE.Descripcion as TipoEdicion From DISCOS D, ESTILOS E, TIPOSEDICION TE Where D.IdEstilo = E.Id AND D.IdTipoEdicion = TE.Id";
                comando.Connection = conexion;

                conexion.Open();

                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Disco aux = new Disco();
                    aux.Id = (int)lector["Id"];
                    aux.Titulo = (string)lector["Titulo"];
                    aux.FechaLanzamiento = (DateTime)lector["FechaLanzamiento"];
                    aux.CantidadCanciones = (int)lector["CantidadCanciones"];
                    aux.ImagenTapa = (string)lector["UrlImagenTapa"];
                    aux.Estilo = (string)lector["Estilo"];
                    aux.TipoEdicion = (string)lector["TipoEdicion"];

                    lista.Add(aux);
                }

                conexion.Close();

                return lista;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
