using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Taxonomia.API.Controllers.Interfaces;
using Taxonomia.API.Models;
using Taxonomia.API.Repositorios;
using Taxonomia.API.Services;

namespace Taxonomia.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DominioController : ControllerBase, IController
    {

        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public async Task<ActionResult<dynamic>> Authenticate([FromBody] Usuarios model)
        {
            var user = Usuario.Get(model.Username, model.Password);

            if (user == null)
                return NotFound(new { message = "Usuario ou senha inválida" });

            var token = TokenService.GenerateToken(user);
            user.Password = "";

            return new
            {
                user = user,
                token = token
            };
        }

        [HttpGet("listar-dominios")] //https://localhost:44354/api/Dominio/listar-dominios
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
        [HttpPost]
        [Route("AdicionarItem")]
        [Authorize]
        public object Adicionar<Dominio>([FromBody] Dominio value) //https://localhost:44354/api/Dominio/Adicionar
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
