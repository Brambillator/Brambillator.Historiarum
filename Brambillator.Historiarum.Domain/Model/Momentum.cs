using Brambillator.Infrastructure.Domain.Models;
using Brambillator.Historiarum.Domain.Lookups;
using System;
using System.Collections.Generic;

namespace Brambillator.Historiarum.Domain.Model
{
    /// <summary>
    /// The most important class in Historiraum.
    /// Describes a moment in time. 
    /// Could be known as a Mark. (Historical mark, happening, event)
    /// </summary>
    public class Momentum : Entity
    {
        public Momentum()
        {
            Resources = new List<MomentumResource>();
            Tempus = new ExtendedDate(DateTime.Now);
            Type = MomentumType.Momentum;
        }

        /// <summary>
        /// Date/Time of the Momentum in history.
        /// Tempus = Time in Latin
        /// </summary>
        public ExtendedDate Tempus { get; set; }
        
        /// <summary>
        /// The kind of source. Is this real or ficction?
        /// </summary>
        public SourceType SourceType { get; set; }

        /// <summary>
        /// Is it a point in time or a period start/end?
        /// </summary>
        public MomentumType Type { get; set; }
        
        // TODO: According to?

        /// <summary>
        /// All resource/media related to this Momentum
        /// </summary>
        public virtual IEnumerable<MomentumResource> Resources { get; set; }

    }
}
