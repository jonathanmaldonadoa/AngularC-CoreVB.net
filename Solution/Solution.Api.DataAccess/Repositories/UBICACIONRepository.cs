using Microsoft.EntityFrameworkCore;
using Solution.Api.DataAccess.Contracts;
using Solution.Api.DataAccess.Contracts.Entities;
using Solution.Api.DataAccess.Contracts.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solution.Api.DataAccess.Repositories
{
    public class UBICACIONRepository : IUBICACIONRepository
    {
        private readonly ISolutionDBContext _solutionDBContext;
        public UBICACIONRepository(ISolutionDBContext solutionDBContext)
        {
            _solutionDBContext = solutionDBContext;
        }

        public async Task<UBICACION> Add(UBICACION Elemnet)
        {
            await _solutionDBContext.UBICACION.AddAsync(Elemnet);
            await _solutionDBContext.SaveChangesAsync();
            return Elemnet;

        }

        public async Task Delete(int id)
        {
            var entity = await _solutionDBContext.UBICACION.SingleAsync(x => x.UbicacionID == id);

            _solutionDBContext.UBICACION.Remove(entity);
            await _solutionDBContext.SaveChangesAsync();
        }

        public async Task<UBICACION> Get(int id)
        {
            var aux = await _solutionDBContext.UBICACION
                .Include(x => x.PERSONA)
                .FirstOrDefaultAsync(x => x.UbicacionID == id);
            return aux;
        }

        public async Task<UBICACION> Update(int id, UBICACION element)
        {
            var entity = await Get(id);
            entity.UbicacionLatitud = element.UbicacionLatitud;

            _solutionDBContext.UBICACION.Update(entity);
            await _solutionDBContext.SaveChangesAsync();
            return entity;
        }

        public async Task<UBICACION> Update(UBICACION element)
        {
            var aux = _solutionDBContext.UBICACION.Update(element);
            await _solutionDBContext.SaveChangesAsync();
            return aux.Entity;
        }
        public async Task<IEnumerable<UBICACION>> GetAll()
        {
            return _solutionDBContext.UBICACION.Include(x => x.PERSONA).Select(x => x);
        }

        public Task<bool> Exist(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
