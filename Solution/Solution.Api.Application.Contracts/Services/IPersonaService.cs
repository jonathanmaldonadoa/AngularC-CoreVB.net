using Solution.Api.Business.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Solution.Api.Application.Contracts.Services
{
    public interface IPersonaService
    {
        Task<IEnumerable<PersonaModel>> GetAll();
    }
}
