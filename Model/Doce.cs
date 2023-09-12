using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiBrigadeiro.Model
{
    public class Doce
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public int Valores { get; set; }
        public int Quantidades { get; set; }
        public string? Sabores { get; set; }
    }
}