using Brambillator.Historiarum.Domain.Model;
using Brambillator.Infrastructure.Domain.Repositories;

namespace Brambillator.Historiarum.Domain.UnitOfWork
{
    public interface IHistoriarumUnitOfWork
    {
        IRepository<Momentum> Momentum { get; }

        void Commit();
    }
}
