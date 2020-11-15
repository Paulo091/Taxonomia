using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taxonomia.API.Controllers.Interfaces
{
    public interface ITaxonomiaDAO<T>
    {
        Task<object> Adicionar([FromBody] T value);
        Task<object> Excluir(int ID);
        Task<object> Alterar([FromBody] T value, int ID);
        Task<object> Selecionar([FromBody] T value);
        public object ListarTodos();
    }
}
