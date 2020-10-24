using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Solution.Api.DataAccess.Contracts.Entities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Solution.Api.DataAccess.Contracts
{
    public interface ISolutionDBContext
    {
        DbSet<EMPRESA> EMPRESAS { get; set; }
        DbSet<PERSONA> PERSONA { get; set; }
        DbSet<TIPODOCUMENTO> TIPODOCUMENTO { get; set; }
        DbSet<UBICACION> UBICACION { get; set; }

        // metodo qeu permiten las operaciones de contexto
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        DatabaseFacade Database { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
        void RemoveRange(IEnumerable<object> entities);
        EntityEntry Update(object entity);


    }
}
