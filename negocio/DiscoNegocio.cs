using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{
    public class DiscoNegocio
    {

        // Metodos
        public List<Disco> listar()
        {
            List<Disco> lista = new List<Disco>();

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setQuery("Select D.Id, Titulo, Autor, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, E.Descripcion as Estilo, E.Id as IdEstilo, TE.Descripcion as TipoEdicion, TE.Id as IdTipoEdicion From DISCOS D, ESTILOS E, TIPOSEDICION TE Where D.IdEstilo = E.Id AND D.IdTipoEdicion = TE.Id\r\n");
                datos.executeReader();

                while(datos.Reader.Read())
                {
                    Disco aux = new Disco();
                    aux.Id = (int)datos.Reader["Id"];
                    aux.Titulo = (string)datos.Reader["Titulo"];
                    aux.Autor = (string)datos.Reader["Autor"];
                    aux.FechaLanzamiento = (DateTime)datos.Reader["FechaLanzamiento"];
                    aux.CantidadCanciones = (int)datos.Reader["CantidadCanciones"];
                    aux.ImagenTapa = (string)datos.Reader["UrlImagenTapa"];

                    aux.Estilo = new Estilo();
                    aux.Estilo.Id = (int)datos.Reader["IdEstilo"];
                    aux.Estilo.Descripcion = (string)datos.Reader["Estilo"];

                    aux.TipoEdicion = new TipoEdicion();
                    aux.TipoEdicion.Id = (int)datos.Reader["IdTipoEdicion"];
                    aux.TipoEdicion.Descripcion = (string)datos.Reader["TipoEdicion"];

                    lista.Add(aux);
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

        public void agregar(Disco disco)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setQuery("INSERT INTO DISCOS (Titulo, Autor, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, IdEstilo, IdTipoEdicion) VALUES (@titulo, @autor, @fecha, @canciones, @imagen, @estilo, @edicion);");
                datos.setParameters("@titulo", disco.Titulo);
                datos.setParameters("@autor", disco.Autor);
                datos.setParameters("@fecha", disco.FechaLanzamiento);
                datos.setParameters("@canciones", disco.CantidadCanciones);
                datos.setParameters("@imagen", disco.ImagenTapa);
                datos.setParameters("@estilo", disco.Estilo.Id);
                datos.setParameters("@edicion", disco.TipoEdicion.Id);

                datos.executeAccion();

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

        public void modificar(Disco disco)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setQuery("UPDATE DISCOS SET Titulo = @titulo, Autor = @autor, FechaLanzamiento = @fecha, CantidadCanciones = @canciones, UrlImagenTapa = @imagen, IdEstilo = @estilo, IdTipoEdicion = @edicion WHERE Id = @id;");

                datos.setParameters("@titulo", disco.Titulo);
                datos.setParameters("@autor", disco.Autor);
                datos.setParameters("@fecha", disco.FechaLanzamiento);
                datos.setParameters("@canciones", disco.CantidadCanciones);
                datos.setParameters("@imagen", disco.ImagenTapa);
                datos.setParameters("@estilo", disco.Estilo.Id);
                datos.setParameters("@edicion", disco.TipoEdicion.Id);
                datos.setParameters("@id", disco.Id);

                datos.executeAccion();
            }
            catch (Exception ex)
            {

                throw ex; 
            }
            finally { datos.closeConexion(); }
        }

        public void eliminar(Disco disco)
        {

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setQuery("DELETE FROM DISCOS WHERE Id = @id;");
                datos.setParameters("@id", disco.Id);

                datos.executeAccion();
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
