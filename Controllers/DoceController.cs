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
    [ApiController]
    [Route("[controller]")]
    public class DoceController : ControllerBase
    {
        private readonly ILogger<DoceController> _logger; 
        private readonly apiBrigadeiroContext _context;

        public DoceController(ILogger<DoceController> logger, apiBrigadeiroContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Doce>> Get()
        {
            var doces = _context.Doces.ToList();
            if (doces.Count == 0)
                return NotFound();
        
            return doces;
        }

        [HttpPost]
        public ActionResult Post(Doce doce)
        {
            _context.Doces.Add(doce);
            _context.SaveChanges();

            return new CreatedAtRouteResult("GetDoce", 
                new {id = doce.Id}, 
                doce);
        }

        [HttpGet("{id:int}", Name="GetDoce")]
        public ActionResult<Doce> Get(int id)
        {
            var doce = _context.Doces.FirstOrDefault(p => p.Id == id);
            if (doce is null)
                return NotFound("Doce não encontrado.");

            return doce;  
        }
        
        [HttpPut ("{id:int}")]
        public ActionResult Put(int id, Doce doce)
        {
            if(id != doce.Id)
                return BadRequest();
            
            _context.Entry(doce).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(doce);
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var doce = _context.Doces.FirstOrDefault(p => p.Id == id);

            if (doce is null)
                return NotFound();
            
            _context.Doces.Remove(doce);
            _context.SaveChanges();

            return Ok(doce);
        }
    }
}