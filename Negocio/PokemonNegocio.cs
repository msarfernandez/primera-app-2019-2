using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class PokemonNegocio
    {
        public List<Pokemon> listar()
        {
            List<Pokemon> lista = new List<Pokemon>();
            Pokemon aux;

            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "data source=MAXIMILIANO8285\\SQLEXPRESS; initial catalog=POKEMON_DB; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                //comando.CommandText = "select p.id, p.Nombre, p.Descripcion PokeDesc, t.Id idTipo, t.Descripcion from POKEMONS p, TIPOS t where p.IdTipo = t.Id";
                // comando.CommandText = "select p.id, p.Nombre, p.Descripcion PokeDesc, t.Id idTipo, t.Descripcion, e.id idEvol,e.Nombre nomEvol from POKEMONS p, TIPOS t, POKEMONS E where p.IdTipo = t.Id and p.IdEvolucion = E.Id";
                comando.CommandText = "select p.id, p.Nombre, p.Descripcion PokeDesc, t.Id idTipo, t.Descripcion, e.id idEvol,e.Nombre nomEvol, p.Imagen from POKEMONS p inner join TIPOS t on p.IdTipo = t.Id left join POKEMONS E on p.IdEvolucion = E.Id";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    aux = new Pokemon();
                    aux.Id = lector.GetInt32(0);
                    aux.Nombre = lector.GetString(1); // lector["Nombre"].ToString();
                    aux.Descripcion = lector.GetString(2); //lector["PokeDesc"].ToString();
                    aux.Tipo = new Tipo();
                    aux.Tipo.Id = (int)lector["idTipo"];
                    aux.Tipo.Descripcion = (string)lector["Descripcion"];
                    if (!Convert.IsDBNull(lector["idEvol"]))
                    {
                        aux.Evolucion = new Pokemon();
                        aux.Evolucion.Id = (int)lector["idEvol"];
                        aux.Evolucion.Nombre = lector["nomEvol"].ToString();
                    }
                    aux.UrlImagen = (string)lector["Imagen"];
                   
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
                conexion.Close();
            }

        }

        public void eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("delete from POKEMONS where id =" + id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void agregar(Pokemon pokemon)
        {
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = "data source=MAXIMILIANO8285\\SQLEXPRESS; initial catalog=POKEMON_DB; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                comando.CommandText = "Insert into POKEMONS values ('" + pokemon.Nombre + "', @idTipo, @idEvolucion, @Desc)";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@idTipo", pokemon.Tipo.Id);
                comando.Parameters.AddWithValue("@idEvolucion", pokemon.Evolucion.Id);
                comando.Parameters.AddWithValue("@Desc", pokemon.Descripcion);

                comando.Connection = conexion;
                conexion.Open();
                comando.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

        public void modificar(Pokemon pokemon)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("Update POKEMONS set Nombre=@Nombre Where Id=@Id");
                datos.agregarParametro("@Nombre", pokemon.Nombre);
                datos.agregarParametro("@Id", pokemon.Id);

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Pokemon> listar2()
        {
            List<Pokemon> lista = new List<Pokemon>();
            Pokemon aux;
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("select p.id, p.Nombre, p.Descripcion PokeDesc, t.Id idTipo, t.Descripcion, e.id idEvol,e.Nombre nomEvol from POKEMONS p inner join TIPOS t on p.IdTipo = t.Id left join POKEMONS E on p.IdEvolucion = E.Id");
                datos.ejecutarLector();
                while (datos.lector.Read())
                {
                    aux = new Pokemon();
                    aux.Id = datos.lector.GetInt32(0);
                    aux.Nombre = datos.lector.GetString(1);
                    aux.Descripcion = datos.lector.GetString(2);
                    aux.Tipo = new Tipo();
                    aux.Tipo.Id = (int)datos.lector["idTipo"];
                    aux.Tipo.Descripcion = (string)datos.lector["Descripcion"];
                    if (!Convert.IsDBNull(datos.lector["idEvol"]))
                    {
                        aux.Evolucion = new Pokemon();
                        aux.Evolucion.Id = (int)datos.lector["idEvol"];
                        aux.Evolucion.Nombre = datos.lector["nomEvol"].ToString();
                    }

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
                datos.cerrarConexion();
                datos = null;
            }

        }
    }
}
