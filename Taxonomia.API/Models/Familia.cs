using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taxonomia.API.Models
{
    public class Familia : CaracteristicasClassificacao
    {
        public int OrdemID { get; set; }
        public Ordem Ordem { get; set; }
    }
}
