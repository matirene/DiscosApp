using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class EstiloNegocio
    {

        public List<Estilo> listar()
        {
            List<Estilo> lista = new List<Estilo>();

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setQuery("SELECT Id, Descripcion FROM ESTILOS;");
                datos.executeReader();

                while (datos.Reader.Read())
                {
                    Estilo estiloAux = new Estilo();

                    estiloAux.Id = (int)datos.Reader["Id"];
                    estiloAux.Descripcion = (string)datos.Reader["Descripcion"];

                    lista.Add(estiloAux);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.closeConexion();
            }

            return lista;
        }
    }
}
