using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taxonomia.API.Models;

namespace Taxonomia.API.Repositorios
{
    public class Usuario
    {
        public static Usuarios Get(string username, string password)
        {
            var users = new List<Usuarios>()
            {
                new Usuarios(){Id=1,Username="Paulo",Password="123",Role="Admin" },
                new Usuarios(){Id=2,Username="Henrique",Password="456",Role="Comum"}
            };

            return users.Find(x => x.Username.ToLower() == username.ToLower() && x.Password.ToLower() == password.ToLower());
        }
    }
}
