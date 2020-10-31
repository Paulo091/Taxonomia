using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taxonomia.API.Controllers.Interfaces
{
    public interface IController
    {
        public object ListarTodos();

        public object Adicionar<T>([FromBody] T value);

        public object Remover<T>([FromBody] T value);
        
        public object Alterar<T>([FromBody] T value);
        public object Pesquisar(string value);


       

    }
}
