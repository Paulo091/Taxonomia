using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Taxonomia.API.Models;
using Taxonomia.API.Repositorios;
using Taxonomia.API.Services;


namespace Taxonomia.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public async Task<ActionResult<dynamic>> Autenticacao([FromBody] Usuarios model)
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
    }      
}
