using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taxonomia.API.Models
{
    public class Genero : CaracteristicasClassificacao
    {
        public int FamiliaID { get; set; }
        public Familia Familia { get; set; }
    }
}
