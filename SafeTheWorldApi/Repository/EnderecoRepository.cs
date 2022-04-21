using Api.Data;
using Business.Interface;
using Business.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api
{
    public class EnderecoRepository : IRepository
    {
        private readonly MeuDbContext _context;

        public EnderecoRepository(MeuDbContext context)
        {
            _context = context;
        }

        public async Task<Endereco> Add(Endereco endereco)
        {
            _context.Add(endereco);
            await _context.SaveChangesAsync();
            return endereco;
        }

        public async Task<Endereco> GetById(int id)
        {
            return await _context.Enderecos.FindAsync(id);
        }

        public async Task<IEnumerable<Endereco>> GetAll()
        {
            return await _context.Enderecos.ToListAsync();
        }


        public async Task Remove(int id)
        {
            var endereco = await _context.Enderecos.FindAsync(id);
            _context.Enderecos.Remove(endereco);
            await _context.SaveChangesAsync();

        }

        public async Task Update(Endereco endereco)
        {
            _context.Entry(endereco).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
