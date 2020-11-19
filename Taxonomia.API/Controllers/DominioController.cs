using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Taxonomia.API.Context;
using Taxonomia.API.DAO.Interfaces;
using Taxonomia.API.DAO;
using Taxonomia.API.Models;
using Taxonomia.API.Repositorios;
using Taxonomia.API.Services;

namespace Taxonomia.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DominioController : ControllerBase, ITaxonomiaDAO<Dominio>
    {
        public TaxonomiaContext contexto;
        public ContextoDAO<TaxonomiaContext> context;

        [HttpGet("listar-dominios")] 
        [Authorize]
        public object ListarTodos() //https://localhost:44354/api/Dominio/listar-dominios
        {           
             using (var contexto = new TaxonomiaContext())
            {
                var resultado = contexto.Dominios.OrderBy(x => x.ID).ToList();

                return JsonSerializer.Serialize(resultado);
            }     
        }

        // POST api/<DominioController>
        [HttpPost]
        [Route("AdicionarItem")]
        [Authorize]
        public async Task<object> Adicionar([FromBody] Dominio dominio) //https://localhost:44354/api/Dominio/AdicionarItem
        {
            try
            {
                contexto = new TaxonomiaContext();

                context = new ContextoDAO<TaxonomiaContext>(contexto);

                await context.InserirAsync(dominio);

                return new
                {
                    Status = true
                };
            }
            catch (Exception e){
                return new
                {
                    Status = false,
                    Msg = e.Message
                };
            }

        }

        // PUT api/<DominioController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete]
        [Route("DeletarItem")]
        public async Task<object> Excluir(int ID)
        {
            try
            {
                using (var contexto = new TaxonomiaContext())
                {
                    var dominio = contexto.Dominios.Where(x => x.ID == ID).FirstOrDefault();
                    contexto.Dominios.Remove(dominio);
                    contexto.SaveChanges();
                }

                return new
                {
                    Status = true
                };
            }
            catch (Exception e)
            {
                return new
                {
                    Status = false,
                    Msg = e.Message
                };
            }
        }

        public async Task<object> Alterar([FromBody] Dominio value, int ID)
        {
            throw new NotImplementedException();
        }

        public async Task<object> Selecionar([FromBody] Dominio value)
        {
            throw new NotImplementedException();
        }

        public async Task<object> ListarColecao([FromBody] Dominio value, int quantidade)
        {
            throw new NotImplementedException();
        }
    }
}
