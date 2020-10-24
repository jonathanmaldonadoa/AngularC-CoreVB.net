using Microsoft.EntityFrameworkCore;
using Solution.Api.DataAccess.Contracts;
using Solution.Api.DataAccess.Contracts.Entities;
using Solution.Api.DataAccess.Contracts.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Solution.Api.DataAccess.Repositories
{
    public class TIPODOCUMENTORepository : ITIPODOCUMENTORepository
    {
        private readonly ISolutionDBContext _solutionDBContext;
        public TIPODOCUMENTORepository(ISolutionDBContext solutionDBContext)
        {
            _solutionDBContext = solutionDBContext;
        }
        public async Task<TIPODOCUMENTO> Add(TIPODOCUMENTO Elemnet)
        {
           await _solutionDBContext.TIPODOCUMENTO.AddAsync(Elemnet);
            await _solutionDBContext.SaveChangesAsync();
            return Elemnet;

        }

        public async Task Delete(int id)
        {
            var entity = await _solutionDBContext.TIPODOCUMENTO.SingleAsync(x => x.TipoDocumentoID == id);

            _solutionDBContext.TIPODOCUMENTO.Remove(entity);
            await _solutionDBContext.SaveChangesAsync();
        }

        public async Task<TIPODOCUMENTO> Get(int id)
        {
            var aux = await _solutionDBContext.TIPODOCUMENTO
                .Include(x => x.PERSONA)
                .FirstOrDefaultAsync(x => x.TipoDocumentoID == id);
            return aux;
        }

        public async Task<TIPODOCUMENTO> Update(int id, TIPODOCUMENTO element)
        {
            var entity = await Get(id);
            entity.TipoDocumentoNombre = element.TipoDocumentoNombre;

            _solutionDBContext.TIPODOCUMENTO.Update(entity);
            await _solutionDBContext.SaveChangesAsync();
            return entity;
        }

        public async Task<TIPODOCUMENTO> Update(TIPODOCUMENTO element)
        {
            var aux = _solutionDBContext.TIPODOCUMENTO.Update(element);
            await _solutionDBContext.SaveChangesAsync();
            return aux.Entity;
        }
        public Task<IEnumerable<TIPODOCUMENTO>> GetAll()
        {
            throw new System.NotImplementedException();
        }
        Task IRepository<TIPODOCUMENTO>.Delete(int id)
        {
            throw new System.NotImplementedException();
        }
        public Task<bool> Exist(int id)
        {
            throw new System.NotImplementedException();
        }


    }
}
