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
    public class ComprasController : ControllerBase
    {
        [HttpGet(Name="compras")]
        public List<Compras> GetCompras()
        {
            List<Compras> compras = new List<Compras>();


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




            Compras compra1 = new Compras();
            compra1.ListaDoces = "Brigadeiro";
            compra1.ValorTotal = 150;
            compra1.FormaPagamento = "Cartão";
            compra1.doces = doces;
            compra1.Cliente = c1;
            compra1.Entrega = e1;


            Compras compra2 = new Compras();
            compra2.ListaDoces = "Beijinho";
            compra2.ValorTotal = 10;
            compra2.FormaPagamento = "Pix";
            compra2.doces = doces;
            compra2.Cliente = c2;
            compra2.Entrega = e2;


            compras.Add(compra1);
            compras.Add(compra2);


            return compras;


        }
       
    }


}
