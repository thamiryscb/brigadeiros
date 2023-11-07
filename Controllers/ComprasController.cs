using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using apiBrigadeiro.Context;
using apiBrigadeiro.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace apiBrigadeiro.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ComprasController : ControllerBase
    {
        private readonly ILogger<ComprasController> _logger;
        private readonly apiBrigadeiroContext _context;
        public ComprasController(ILogger<ComprasController> logger, apiBrigadeiroContext context)
        {
            _logger = logger;
            _context = context;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Compras>> Get()
        {
            var compras = _context.Compras.ToList();
            if(compras.Count == 0)
                return NotFound();

            return compras;
        }

        [HttpPost]
        public ActionResult Post(Compras compras){
            _context.Compras.Add(compras);
            _context.SaveChanges();

            return new CreatedAtRouteResult("GetCompras",
                new{id = compras.Id},
                compras);
        }

        [HttpGet("{id:int}", Name="GetCompras")]
        public ActionResult<Compras> Get(int id)
        {
            var compras = _context.Compras.FirstOrDefault(p => p.Id == id);
            if(compras is null)
                return NotFound("Compra não encontrado.");

            return compras;
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Compras compras){
            if(id != compras.Id)
                return BadRequest();
            
            _context.Entry(compras).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(compras);
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id){
            var compras = _context.Compras.FirstOrDefault(p => p.Id == id);

            if(compras is null)
                return NotFound();
            
            _context.Compras.Remove(compras);
            _context.SaveChanges();

            return Ok(compras);
        }
    }
}