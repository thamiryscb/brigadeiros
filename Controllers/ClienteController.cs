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
            var clientes = _context.Clientes.ToList();
            if(clientes.Count == 0)
                return NotFound();

            return clientes;
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
                return NotFound("Cliente não encontrado.");
            
            _context.Clientes.Remove(cliente);
            _context.SaveChanges();

            return Ok(cliente);
        }
    }
}