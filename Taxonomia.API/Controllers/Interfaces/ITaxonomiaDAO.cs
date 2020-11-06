using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taxonomia.API.Controllers.Interfaces
{
    public interface ITaxonomiaDAO<T>
    {
        public object Adicionar([FromBody] T value);
        public object Excluir(int ID);        
        public object Alterar([FromBody] T value, int ID);
        public object Selecionar([FromBody] T value);
        public object ListarColecao([FromBody] T value,int quantidade);
    }
}
