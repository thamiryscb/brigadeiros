using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiBrigadeiro.Model;
using Microsoft.AspNetCore.Mvc;

namespace apiBrigadeiro.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DoceController : ControllerBase
    {
        [HttpGet(Name = "doces")]
        public List<Doce> GetDoce()
        {
            List<Doce> doces = new List<Doce>();

            Doce d1 = new Doce();
            d1.Nome = "Beijinho";
            d1.Valores = 30;
            d1.Quantidades = 20;
            d1.Sabores = "Coco";

            Doce d2 = new Doce();
            d2.Nome = "Brigadeiro Tradicional";
            d2.Valores = 30;
            d2.Quantidades = 20;
            d2.Sabores = "Chocolate";

            doces.Add(d1);
            doces.Add(d2);

            return doces;
        }
    }
}