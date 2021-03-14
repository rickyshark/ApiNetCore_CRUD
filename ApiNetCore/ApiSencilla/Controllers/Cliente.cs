using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiSencilla.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiSencilla.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Cliente : ControllerBase
    {
        private readonly AplicationDbContext _context;

        public Cliente (AplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/<Cliente>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var listaC = await _context.clientes.ToListAsync();

            return Ok(listaC);
        }

        // GET api/<Cliente>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Cliente>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Cliente>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Cliente>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
