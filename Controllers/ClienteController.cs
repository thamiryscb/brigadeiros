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
    public class ClienteController : ControllerBase
    {
        [HttpGet(Name = "clientes")]
        public List<Cliente> GetCliente()
        {
            List<Cliente> clientes = new List<Cliente>();

            Cliente c1 = new Cliente();
            c1.Nome = "Ana";
            c1.Endereço = "Rua do Pardal";
            c1.Telefone = "321654987"; 
            c1.Email = "ana@gmail.com";
            c1.Senha = "123456";

            Cliente c2 = new Cliente();
            c2.Nome = "Vera";
            c2.Endereço = "Rua Florada";
            c2.Telefone = "125463987"; 
            c2.Email = "vera@gmail.com";
            c2.Senha = "147852";

            clientes.Add(c1);
            clientes.Add(c2);

            return clientes; 
        }
        
    }
}