using Business.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Interface
{
    public interface IRepository
    {
        Task<IEnumerable<Endereco>> GetAll();
        Task<Endereco> GetById(int id);
        Task<Endereco> Add(Endereco endereco);
        Task Update(Endereco endereco);
        Task Remove(int id);
    }
}
