using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace brigadeiros.Model
{
    public class Avaliação
    {
        public string? Nome {get; set;}
        public Avaliação(int nota) 
        {
            this.Nota = nota;
   
        }
    
        public int Nota {get; set;}
        public string? Data {get; set;}

    }
}