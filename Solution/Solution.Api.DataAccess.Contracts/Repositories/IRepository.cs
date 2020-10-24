using System.Collections.Generic;
using System.Threading.Tasks;

namespace Solution.Api.DataAccess.Contracts.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<bool> Exist(int id);
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(int id);
        Task Delete(int id);
        Task<T> Update(int id, T element);
        Task<T> Add(T Elemnet);
    }
}
