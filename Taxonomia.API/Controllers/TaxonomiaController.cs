using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Taxonomia.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaxonomiaController : ControllerBase
    {
        public string Index() //https://localhost:44354/Taxonomia/
        {
            return "inicio API";
        }

        [HttpGet("Pesquisar/Especie")] //https://localhost:44354/Taxonomia/Pesquisar/Especie
        public object Especie()
        {
            return new
            {
                Especie = "teste"
            };
        }

        [HttpGet("Pesquisar/Filo")] //https://localhost:44354/Taxonomia/Pesquisar/Filo
        public string Filo()
        {
            return "Filo";
        }

    }
}
