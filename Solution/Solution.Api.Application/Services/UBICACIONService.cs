using Solution.Api.Application.Contracts.Services;
using Solution.Api.Business.Models;
using Solution.Api.DataAccess.Contracts.Entities;
using Solution.Api.DataAccess.Contracts.Repositories;
using Solution.Api.DataAccess.Mappers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solution.Api.Application.Services
{
    public class UBICACIONService : IUBICACIONService
    {
        private readonly IUBICACIONRepository _IUBICACIONRepository;

        public UBICACIONService(IUBICACIONRepository iUBICACIONRepository)
        {
            _IUBICACIONRepository = iUBICACIONRepository;
        }

        public async Task<IEnumerable<UbicacionModel>> GetAll()
        {
            var entitys = await _IUBICACIONRepository.GetAll();
            var aux = entitys.Select(UbicacionMapper.Map);
            return aux;
        }

        public async Task<UbicacionModel> Add(UbicacionModel obj)
        {
            var entity = await _IUBICACIONRepository.Add(UbicacionMapper.Map(obj));
            return UbicacionMapper.Map(entity);
        }

    }
}
