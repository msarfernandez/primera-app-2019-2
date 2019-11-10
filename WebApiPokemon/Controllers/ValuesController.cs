using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dominio;
using Negocio;

namespace WebApiPokemon.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public List<Pokemon> Get()
        {
            PokemonNegocio negocio = new PokemonNegocio();
            // return new string[] { "Pikachu", "Charmander" };
            return negocio.listar();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
