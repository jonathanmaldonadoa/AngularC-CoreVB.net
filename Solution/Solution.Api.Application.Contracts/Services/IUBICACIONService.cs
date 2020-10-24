using Solution.Api.Business.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Solution.Api.Application.Contracts.Services
{
    public interface IUBICACIONService
    {
        Task<IEnumerable<UbicacionModel>> GetAll();
        Task<UbicacionModel> Add(UbicacionModel obj);
    }
}
