using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.EntityFrameworkCore;
using Brambillator.Historiarum.Repositories.EntityFramework;
using Brambillator.Historiarum.Service;
using Brambillator.CulturedMedia.Service;
using Brambillator.Historiarum.Domain.Model;

namespace Brambillator.Historiarum.Test
{
    [TestClass]
    public class MomentumServiceTest
    {
        private string connectionStringForResources = @"Server=(localdb)\MSSQLLocalDB;Database=HistoriarumResourceTestDB;Trusted_Connection=True;";
        private string connectionStringForHistoriarum = @"Server=(localdb)\MSSQLLocalDB;Database=HistoriarumTestDB;Trusted_Connection=True;";
        DbContextOptionsBuilder optionsBuilderForResources = new DbContextOptionsBuilder();
        DbContextOptionsBuilder optionsBuilderForHistoriarum = new DbContextOptionsBuilder();

        public MomentumServiceTest()
        {
            optionsBuilderForResources.UseSqlServer(connectionStringForResources);
            optionsBuilderForHistoriarum.UseSqlServer(connectionStringForHistoriarum);
            EFHistoriarumUnitOfWorkInitializer.Initialize(new EFHistoriarumUnitOfWork(optionsBuilderForHistoriarum.Options));
        }

        [TestMethod]
        public void MomentumServiceTest_NewMomentum()
        {
            ResourceService resourceService = new ResourceService(optionsBuilderForResources.Options);
            EFHistoriarumUnitOfWork unitOfWork = new EFHistoriarumUnitOfWork(optionsBuilderForHistoriarum.Options);
            MomentumService momentumService = new MomentumService(unitOfWork, resourceService);

            ExtendedDate momentumDate = new ExtendedDate();
            momentumDate.Scale = Domain.Lookups.TimeScale.DateTime;
            momentumDate.Amount = new DateTime(2017, 8, 25).Ticks;

            string[] keys = { "FIRST_MOMENTUM_SERVICE_TEST" };

            momentumService.CreateMomentum("en-US"
                                            , Domain.Lookups.SourceType.HistoricalFact
                                            , Domain.Lookups.MomentumType.Momentum
                                            , momentumDate
                                            , keys);
        }
    }
}
