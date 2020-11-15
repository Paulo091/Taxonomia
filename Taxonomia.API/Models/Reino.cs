using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taxonomia.API.Models
{
    public class Reino : CaracteristicasClassificacao
    {
        public int DominioID { get; set; }
        public Dominio Dominio { get; set; }
    }
}
