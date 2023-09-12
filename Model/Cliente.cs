using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiBrigadeiro.Model
{
    public class Cliente
    {
        public int Id {get; set;}
        public string? Nome {get; set;}
        public string? Endereço { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        
    }
}