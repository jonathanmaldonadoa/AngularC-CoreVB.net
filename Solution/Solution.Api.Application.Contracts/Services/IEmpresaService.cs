using Solution.Api.Business.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Solution.Api.Application.Contracts.Services
{
    public interface IEmpresaService
    {
        Task<IEnumerable<EmpresaModel>> GetAll();
        Task<bool> Delte(int id);
        Task<EmpresaModel> Get(int id);
        Task<EmpresaModel> Add(EmpresaModel empresaModel);
    }
}
