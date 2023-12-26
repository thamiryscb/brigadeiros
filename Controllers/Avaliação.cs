using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using apiBrigadeiro.Context;
using brigadeiros.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;


namespace brigadeiros.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [ApiController]
    [Route("[controller]")]
    public class AvaliaçãoController : ControllerBase
    {
        private readonly ILogger<AvaliaçãoController> _logger;
        private readonly apiBrigadeiroContext _context;
        public AvaliaçãoController(ILogger<AvaliaçãoController> logger, apiBrigadeiroContext context)
        {
            _logger = logger;
            _context = context;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Avaliação>> Get()
        {
            var avaliação = _context.Avaliações.ToList();
            if (avaliação.Count == 0)
                return NotFound();

            return avaliação;
        }

        [HttpPost]
        public ActionResult Post(Avaliação avaliação){
            _context.Avaliações.Add(avaliação);
            _context.SaveChanges();

            return new CreatedAtRouteResult("GetAvaliação",
                new{id = avaliação.Id},
                avaliação);
        }

        [HttpGet("{id:int}", Name="GetAvaliação")]
        public ActionResult<Avaliação> Get(int id)
        {
            var avaliação = _context.Avaliações.FirstOrDefault(p => p.Id == id);
            if(avaliação is null)
                return NotFound("Avaliação não encontrada.");

            return avaliação;
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Avaliação avaliação){
            if(id != avaliação.Id)
                return BadRequest();
            
            _context.Entry(avaliação).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(avaliação);
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id){
            var avaliação = _context.Avaliações.FirstOrDefault(p => p.Id == id);

            if(avaliação is null)
                return NotFound();
            
            _context.Avaliações.Remove(avaliação);
            _context.SaveChanges();

            return Ok(avaliação);
        }
    }
}