using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace brigadeiros.DTO
{
    public class UsuarioToken
    {
        public bool Authenticated {get; set;}
        public DateTime Experation {get; set;}
        public string Token {get; set;}
        public string Message {get;set;}
    }
}