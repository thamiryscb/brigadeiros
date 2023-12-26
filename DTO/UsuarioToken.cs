using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace apiBrigadeiro.DTO
{
    public class UsuarioToken
    {
        public bool Authenticated {get; set;}
        public DateTime Expiration {get; set;}
        public string Token {get; set;}
        public string Message {get;set;}
    }
}