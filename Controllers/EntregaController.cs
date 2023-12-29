using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using apiBrigadeiro.Context;
using apiBrigadeiro.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace apiBrigadeiro.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/{v:apiversion}/entrega")]
    public class EntregaController : ControllerBase
    {
        private readonly ILogger<EntregaController> _logger;
        private readonly apiBrigadeiroContext _context;

        public EntregaController(ILogger<EntregaController> logger, apiBrigadeiroContext context)
        {
            _logger = logger;
            _context = context;
            
        }

         [HttpGet]
        public ActionResult<IEnumerable<Entrega>> Get()
        {
            var entregas = _context.Entregas.ToList();
            if (entregas.Count == 0)
                return NotFound();

            return entregas;
        }

        [HttpGet("{id:int}", Name ="GetEntrega")]
        public ActionResult<Entrega> Get(int id)
        {
            var entrega = _context.Entregas.FirstOrDefault(p => p.Id == id);
            if(entrega is null)
                return NotFound("Entrega não encontrada.");
            
            return entrega;
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Entrega entrega){
            if(id != entrega.Id)
                return BadRequest();
            _context.Entry(entrega).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(entrega);
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id){
            var entrega = _context.Entregas.FirstOrDefault(p => p.Id == id);

            if (entrega is null)
                return NotFound();
            _context.Entregas.Remove(entrega);
            _context.SaveChanges();

            return Ok(entrega);
        }

        [HttpPost]
        public ActionResult Post(Entrega entrega){
            _context.Entregas.Add(entrega);
            _context.SaveChanges();

            return new CreatedAtRouteResult("GetEntrega",
                new {id = entrega.Id},
                entrega);
        }

    }
}
