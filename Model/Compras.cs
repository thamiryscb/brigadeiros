using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace apiBrigadeiro.Model
{
    public class Compras
    {
        public int Id {get; set;}
        public int ValorTotal {get; set;}
        public string? FormaPagamento {get; set;}

        public List<Doce> doces {get; set;}

        public Compras()
       {
            doces = new List<Doce>();

       }
    }
}
