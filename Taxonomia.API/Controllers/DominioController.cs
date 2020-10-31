using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Taxonomia.API.Controllers.Interfaces;
using Taxonomia.API.Models;

namespace Taxonomia.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DominioController : ControllerBase, IController
    {
        [HttpGet("listar-dominios")] //https://localhost:44354/Dominio/listar-dominios
        public object ListarTodos()
        {

            string[] Dominios = new String[3];

            Dominios[0] = "Eucaria";
            Dominios[1] = "Arqueia";
            Dominios[2] = "Bacteria";

            var json = JsonSerializer.Serialize(Dominios);

            return json;
     
        }

        // POST api/<DominioController>
        [HttpPost("Adicionar")]
        public object Adicionar<Dominio>([FromBody] Dominio value) //https://localhost:44354/Dominio/Adicionar
        {
            return new
            {
                Status = 1
            };
        }

        public object Remover<T>([FromBody] T value)
        {
            throw new NotImplementedException();
        }

        public object Alterar<T>([FromBody] T value)
        {
            throw new NotImplementedException();
        }

        public object Pesquisar(string value)
        {
            throw new NotImplementedException();
        }


        // PUT api/<DominioController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DominioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

    }
}
