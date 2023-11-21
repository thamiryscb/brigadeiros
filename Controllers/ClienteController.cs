using apiBrigadeiro.Context;
using apiBrigadeiro.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace apiBrigadeiro.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class ClienteController : ControllerBase
    {
        private readonly ILogger<ClienteController> _logger;
        private readonly apiBrigadeiroContext _context;
        public ClienteController(ILogger<ClienteController> logger, apiBrigadeiroContext context)
        {
            _logger = logger;
            _context = context;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Cliente>> Get()
        {
            var cliente = _context.Clientes.ToList();
            if(cliente.Count == 0)
                return NotFound();

            return cliente;
        }

        [HttpPost]
        public ActionResult Post(Cliente cliente){
            _context.Clientes.Add(cliente);
            _context.SaveChanges();

            return new CreatedAtRouteResult("GetCliente",
                new{id = cliente.Id},
                cliente);
        }

        [HttpGet("{id:int}", Name="GetCliente")]
        public ActionResult<Cliente> Get(int id)
        {
            var cliente = _context.Clientes.FirstOrDefault(p => p.Id == id);
            if(cliente is null)
                return NotFound("Cliente não encontrado.");

            return cliente;
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Cliente cliente){
            if(id != cliente.Id)
                return BadRequest();
            
            _context.Entry(cliente).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(cliente);
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id){
            var cliente = _context.Clientes.FirstOrDefault(p => p.Id == id);

            if(cliente is null)
                return NotFound();
            
            _context.Clientes.Remove(cliente);
            _context.SaveChanges();

            return Ok(cliente);
        }
    }
}