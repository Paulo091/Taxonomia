using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taxonomia.API.Models
{
    public class Filo : CaracteristicasClassificacao
    {
        public int ReinoID { get; set; }
        public Reino Reino { get; set; }
    }
}
