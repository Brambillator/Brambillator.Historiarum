using Brambillator.Historiarum.Domain.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using System;
using Brambillator.Infrastructure.Domain.Repositories;
using Brambillator.Historiarum.Domain.Model;

namespace Brambillator.Historiarum.Repositories.EntityFramework
{
    public class EFHistoriarumUnitOfWork : DbContext, IHistoriarumUnitOfWork
    {
        private readonly EfRepository<Momentum> momentum;
        private DbSet<Momentum> MomentumSet { get; set; }

        public EFHistoriarumUnitOfWork()
        {
            momentum = new EfRepository<Momentum>(MomentumSet);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //TODO: Make provider configurable
            //(LocalDb)\MSSQLLocalDB
            //(localdb)\v11.0
            optionsBuilder.UseSqlServer(@"Server=(LocalDb)\MSSQLLocalDB;Database=Historiarum;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Momentum>().ToTable("Momentum", "Historiarum");
        }

        public IRepository<Momentum> Momentum
        {
            get { return momentum; }
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }
    }
}
