using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taxonomia.API.Models
{
    public class Especie : CaracteristicasClassificacao
    {
        public int GeneroID { get; set; }
        public Genero Genero { get; set; }
    }
}
