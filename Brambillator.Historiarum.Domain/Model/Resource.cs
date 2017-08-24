using Brambillator.Infrastructure.Domain.Models;

namespace Brambillator.Historiarum.Domain.Model
{
    /// <summary>
    /// Media that can be related to a Momentum/Mark
    /// </summary>
    public class MomentumResource : Entity
    {
        /// <summary>
        /// Key for CulturedMedia resource
        /// </summary>
        public string CulturedMediaKey { get; set; }

        /// <summary>
        /// Momentum related to this media.
        /// </summary>
        public virtual Momentum Momentum { get; set; }
    }
}
