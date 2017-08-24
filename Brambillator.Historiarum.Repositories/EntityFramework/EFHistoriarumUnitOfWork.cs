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
        private DbSet<Momentum> Momentum { get; set; }

        public EFHistoriarumUnitOfWork(DbContextOptions options) : base(options)
        {
            //@"Server=(LocalDb)\MSSQLLocalDB;Database=Historiarum;Trusted_Connection=True;"
            momentum = new EfRepository<Momentum>(Momentum);
        }

        public IRepository<Momentum> MomentumRepository
        {
            get { return momentum; }
        }

        public void Commit()
        {
            this.SaveChanges();
        }
    }
}
