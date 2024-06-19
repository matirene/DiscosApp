using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class NegocioTipoEdicion
    {
        public List<TipoEdicion> listar()
        {
            List<TipoEdicion> lista = new List<TipoEdicion>();

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setQuery("SELECT Id, Descripcion FROM TIPOSEDICION;");
                datos.executeReader();


                while(datos.Reader.Read())
                {
                    TipoEdicion tipoEdicionAux = new TipoEdicion();

                    tipoEdicionAux.Id = (int)datos.Reader["Id"];
                    tipoEdicionAux.Descripcion = (string)datos.Reader["Descripcion"];

                    lista.Add(tipoEdicionAux);
                }

                return lista;

            }
            catch (Exception ex)
            {

                throw ex;
            } 
            finally
            {
                datos.closeConexion();
            }


        }
    }
}
