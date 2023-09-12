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
    public class EntregaController : ControllerBase
    {
        [HttpGet(Name = "entregas")]
        public List<Entrega> GetEntrega()
        {
            List<Entrega> entregas = new List<Entrega>();


            Entrega e1 = new Entrega();
            e1.Endereco = "Rua da Platina";
            e1.Status = "Saiu para entrega";
            e1.Frete = 10;


            Entrega e2 = new Entrega();
            e2.Endereco = "Rua Lula Gomes";
            e2.Status = "Entrega realizada";
            e2.Frete = 15;


            entregas.Add(e1);
            entregas.Add(e2);


            return entregas;
        }
    }
}
