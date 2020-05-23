using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class TipoNegocio
    {
       public List<Tipo> listar()
        {
            SqlDataReader lector;
            SqlConnection cn = new SqlConnection();
            SqlCommand cm = new SqlCommand();
            Tipo aux;
            List<Tipo> lista = new List<Tipo>();
            try
            {
                cn.ConnectionString = "data source=MAXIMILIANO8285\\SQLEXPRESS ; initial catalog=POKEMON_DB; integrated security=sspi";
                cm.CommandType = System.Data.CommandType.Text;
                cm.CommandText = "Select Id, Descripcion From TIPOS";
                cm.Connection = cn;
                cn.Open();
                lector = cm.ExecuteReader();

                while (lector.Read())
                {
                    aux = new Tipo((int)lector["Id"], (string)lector["Descripcion"]);
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
                cn.Close();
            }
        }
    }
}
