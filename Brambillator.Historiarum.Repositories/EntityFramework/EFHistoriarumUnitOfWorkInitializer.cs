namespace Brambillator.Historiarum.Repositories.EntityFramework
{
    public static class EFHistoriarumUnitOfWorkInitializer
    {
        public static void Initialize(EFHistoriarumUnitOfWork context)
        {
            context.Database.EnsureCreated();
        }
    }
}
