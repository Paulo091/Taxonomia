using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Taxonomia.API.Gerenciador.Configuracoes;
using Taxonomia.API.Models;

namespace Taxonomia.API.Services
{
    public class TokenService
    {
        public static string GenerateToken(Usuarios user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(SecretKeyJWTSettings.Secret); //Encodando a secret para bytes

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                    {
                        //Utilizando claims publicas
                        new Claim(ClaimTypes.Name, user.Username.ToString()),
                        new Claim(ClaimTypes.Role, user.Role.ToString())
                    }
                ),
                Expires = DateTime.UtcNow.AddMinutes(3),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256) //new SigningCredentials(chave, tipoCriptografia)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
