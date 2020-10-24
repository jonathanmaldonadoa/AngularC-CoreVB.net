using Microsoft.EntityFrameworkCore;
using Solution.Api.DataAccess.Contracts;
using Solution.Api.DataAccess.Contracts.Entities;
using Solution.Api.DataAccess.Contracts.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solution.Api.DataAccess.Repositories
{
    public class EMPRESARepository : IEMPRESARepository
    {
        private readonly ISolutionDBContext _solutionDBContext;
        public EMPRESARepository(ISolutionDBContext solutionDBContext)
        {
            _solutionDBContext = solutionDBContext;
        }

        public async Task<EMPRESA> Add(EMPRESA Elemnet)
        {
            await _solutionDBContext.EMPRESAS.AddAsync(Elemnet);
            await _solutionDBContext.SaveChangesAsync();
            return Elemnet;

        }

        public async Task Delete(int id)
        {
            var entity = await _solutionDBContext.EMPRESAS.SingleAsync(x => x.EmpresaID == id);

            _solutionDBContext.EMPRESAS.Remove(entity);
            await _solutionDBContext.SaveChangesAsync();
        }

        public async Task<EMPRESA> Get(int id)
        {
            var aux = await _solutionDBContext.EMPRESAS
                .Include(x => x.TIPO_DOCUMENTO)
                .FirstOrDefaultAsync(x => x.EmpresaID == id);
            return aux;
        }

        public async Task<EMPRESA> Update(int id, EMPRESA element)
        {
            var entity = await Get(id);
            entity.EmpresaNombre = element.EmpresaNombre;

            _solutionDBContext.EMPRESAS.Update(entity);
            await _solutionDBContext.SaveChangesAsync();
            return entity;
        }

        public async Task<EMPRESA> Update(EMPRESA element)
        {
            var aux = _solutionDBContext.EMPRESAS.Update(element);
            await _solutionDBContext.SaveChangesAsync();
            return aux.Entity;
        }
        public async Task<IEnumerable<EMPRESA>> GetAll()
        {
            return _solutionDBContext.EMPRESAS.Select(x => x);
        }
        public Task<bool> Exist(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
