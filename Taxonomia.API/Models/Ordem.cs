using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taxonomia.API.Models
{
    public class Ordem : CaracteristicasClassificacao
    {
        public int ClasseID { get; set; }
        public Classe Classe { get; set; }
    }
}
