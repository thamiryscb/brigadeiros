using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace apiBrigadeiro.Model
{
    public class Pedido
    {
        public int Id {get; set;}
        public int ValorTotal {get; set;}
        public string? FormaPagamento {get; set;}

        public List<Doce> doces {get; set;}
        public List<Entrega> entregas {get; set;}

        public Pedido()
       {
            doces = new List<Doce>();
            entregas = new List<Entrega>();

       }
    }
}
