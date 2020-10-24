using Microsoft.EntityFrameworkCore;
using Solution.Api.DataAccess.Contracts;
using Solution.Api.DataAccess.Contracts.Entities;
using System.Linq;

namespace Solution.Api.DataAccess
{
    public class SolutionDBContext : DbContext, ISolutionDBContext
    {
        public SolutionDBContext()
        {

        }
        public SolutionDBContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //quita delete en cadena
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }

        public DbSet<EMPRESA> EMPRESAS { get; set; }
        public DbSet<PERSONA> PERSONA { get; set; }
        public DbSet<TIPODOCUMENTO> TIPODOCUMENTO { get; set; }
        public DbSet<UBICACION> UBICACION { get; set; }
    }
}
