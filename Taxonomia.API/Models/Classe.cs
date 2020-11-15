using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taxonomia.API.Models
{
    public class Classe : CaracteristicasClassificacao
    {
        public int FiloID { get; set; }
        public Filo Filo { get; set; }
    }
}
