using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace apiBrigadeiro.Model
{
    public class Entrega
    {
        public int Id { get; set; }
        public string? Endereco {get; set;}
        public string Status {get; set;}
        public int Frete {get; set;}
    }
}
