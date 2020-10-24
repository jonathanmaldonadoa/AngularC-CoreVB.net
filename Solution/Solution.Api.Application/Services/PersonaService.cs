using Solution.Api.Application.Contracts.Services;
using Solution.Api.Business.Models;
using Solution.Api.DataAccess.Contracts.Repositories;
using Solution.Api.DataAccess.Mappers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solution.Api.Application.Services
{
    public class  PersonaService : IPersonaService
    {
        private readonly IPERSONARepository _IPERSONARepository;

        public PersonaService(IPERSONARepository iPERSONARepository)
        {
            _IPERSONARepository = iPERSONARepository;
        }

        public async Task<IEnumerable<PersonaModel>> GetAll()
        {
            var entitys = await _IPERSONARepository.GetAll();
            var aux = entitys.Select(PersonaMapper.Map);
            return aux;
        }

    }
}
