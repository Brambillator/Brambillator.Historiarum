using Brambillator.CulturedMedia.Domain.UnitOfWork;
using Brambillator.CulturedMedia.Domain.Views;
using Brambillator.CulturedMedia.Service;
using Brambillator.Historiarum.Domain.Model;
using Brambillator.Historiarum.Domain.UnitOfWork;
using Historiarum.Data.Lookups;
using System.Collections.Generic;

namespace Brambillator.Historiarum.Service
{
    public class MomentumService
    {
        private IHistoriarumUnitOfWork _unitOfWork { get; set; }
        private IResourceService _resourceService { get; set; }

        /// <summary>
        /// Constructs a new instance of <see cref="MomentumService"/> with given repository.
        /// </summary>
        /// <param name="unitOfWork"></param>
        public MomentumService(IHistoriarumUnitOfWork unitOfWorkForMomentum, IResourceService resourceService)
        {
            _unitOfWork = unitOfWorkForMomentum;
            _resourceService = resourceService;
        }

        public void CreateMomentum(string cultureName, Domain.Model.System system, SourceType sourceType, MomentumType momentumType, ExtendedDate tempus, IList<Resource> resources)
        {
            Momentum newMomentum = new Momentum();
            newMomentum.SourceType = sourceType;
            newMomentum.Tempus = tempus;
            newMomentum.Type = momentumType;
            newMomentum.SourceSystem = system;
            //newMomentum.Resources = resources;

            List<MomentumResource> resourceList = new List<MomentumResource>();
            foreach (Resource res in resources)
            {
                //_resourceService.CreateOrUpdate()
                resourceList.Add(new  MomentumResource() { CulturedMediaKey = res.Key });
            }

            newMomentum.Resources = resourceList;

            //newMomentum.State = Infrastructure.Domain.Models.EntityState.Added;
            _unitOfWork.Momentum.Add(newMomentum);
            _unitOfWork.Commit();
        }
    }
}
