using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiBrigadeiro.Context;
using brigadeiros.Model;
using Microsoft.AspNetCore.Mvc;

namespace brigadeiros.Controllers
{
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
    }
}