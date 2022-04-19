using Business.Interface;
using Business.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecoController : ControllerBase
    {

        private readonly IRepository _context;

        public EnderecoController(IRepository context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Endereco>>> Get()
        {
            try
            {
                var endereco = await _context.GetAllAsync();

                if (endereco == null)
                {
                    return NotFound("Endereço not found");
                }
                return Ok(endereco);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Endereco>> GetById(int id)
        {
            try
            {
                var endereco = await _context.GetById(id);

                if (endereco == null)
                {
                    return NotFound("Endereço not found");
                }
                return Ok(endereco);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        public async Task<ActionResult<Endereco>> Post([FromBody] Endereco endereco)
        {
            var enderecos = await _context.Add(endereco);
            return enderecos;
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var enderecoDelete = await _context.GetById(id);

            if (enderecoDelete == null)
            {
                return NotFound("Endereco not found");
            }
            await _context.Remove(id);
            return Ok(enderecoDelete);
        }

        [HttpPut]
        public async Task<ActionResult> Update(int id,[FromBody] Endereco endereco)
        {
           
            if (id != endereco.Id)
                return BadRequest();

            await _context.Update(endereco);
            
            return NoContent();
        }
    }
}