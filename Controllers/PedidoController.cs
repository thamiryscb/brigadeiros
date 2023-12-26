using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiBrigadeiro.Model;
using apiBrigadeiro.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace apiBrigadeiro.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [ApiController]
    [Route("[controller]")]
    public class PedidoController : ControllerBase
    {
        private readonly ILogger<PedidoController> _logger;
        private readonly apiBrigadeiroContext _context;
        public PedidoController(ILogger<PedidoController> logger, apiBrigadeiroContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Pedido>> Get()
        {
            var pedidos = _context.Pedidos.ToList();
            if (pedidos.Count == 0)
                return NotFound();
        
            return pedidos;
        }

        [HttpPost]
        public ActionResult Post(Pedido pedido)
        {
            _context.Pedidos.Add(pedido);
            _context.SaveChanges();

            return new CreatedAtRouteResult("GetPedido", 
                new {id = pedido.Id}, 
                pedido);
        }

        [HttpGet("{id:int}", Name="GetPedido")]
        public ActionResult<Pedido> Get(int id)
        {
            var pedido = _context.Pedidos.FirstOrDefault(p => p.Id == id);
            if (pedido is null)
                return NotFound("Pedido não encontrado.");

            return pedido;  
        }
        
        [HttpPut ("{id:int}")]
        public ActionResult Put(int id, Pedido pedido)
        {
            if(id != pedido.Id)
                return BadRequest();
            
            _context.Entry(pedido).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(pedido);
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var pedido = _context.Pedidos.FirstOrDefault(p => p.Id == id);

            if (pedido is null)
                return NotFound("Pedido não encontrado.");
            
            _context.Pedidos.Remove(pedido);
            _context.SaveChanges();

            return Ok(pedido);
        }
    }
}