using Microsoft.EntityFrameworkCore;
using Solution.Api.DataAccess.Contracts;
using Solution.Api.DataAccess.Contracts.Entities;
using Solution.Api.DataAccess.Contracts.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solution.Api.DataAccess.Repositories
{
    public class PERSONARepository : IPERSONARepository
    {
        private readonly ISolutionDBContext _solutionDBContext;
        public PERSONARepository(ISolutionDBContext solutionDBContext)
        {
            _solutionDBContext = solutionDBContext;
        }

        public async Task<PERSONA> Add(PERSONA Elemnet)
        {
            await _solutionDBContext.PERSONA.AddAsync(Elemnet);
            await _solutionDBContext.SaveChangesAsync();
            return Elemnet;

        }

        public async Task Delete(int id)
        {
            var entity = await _solutionDBContext.PERSONA.SingleAsync(x => x.PersonaID == id);

            _solutionDBContext.PERSONA.Remove(entity);
            await _solutionDBContext.SaveChangesAsync();
        }

        public async Task<PERSONA> Get(int id)
        {
            var aux = await _solutionDBContext.PERSONA
                .Include(x => x.TIPODOCUMENTO)
                .FirstOrDefaultAsync(x => x.PersonaID == id);
            return aux;
        }

        public async Task<PERSONA> Update(int id, PERSONA element)
        {
            var entity = await Get(id);
            entity.PersonaNombre = element.PersonaNombre;

            _solutionDBContext.PERSONA.Update(entity);
            await _solutionDBContext.SaveChangesAsync();
            return entity;
        }

        public async Task<PERSONA> Update(PERSONA element)
        {
            var aux = _solutionDBContext.PERSONA.Update(element);
            await _solutionDBContext.SaveChangesAsync();
            return aux.Entity;
        }
        public async Task<IEnumerable<PERSONA>> GetAll() 
        {
            return  _solutionDBContext.PERSONA.Include(x => x.UBICACION).Include(x=>x.TIPODOCUMENTO).Select(x => x);
        }
        public Task<bool> Exist(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
