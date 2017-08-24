using Brambillator.Infrastructure.Domain.Models;
using Brambillator.Historiarum.Domain.Lookups;

namespace Brambillator.Historiarum.Domain.Model
{
    /// <summary>
    /// Media that can be related to a Momentum/Mark
    /// </summary>
    public class Media : Entity
    {
        /// <summary>
        /// Culture of this media (Commonly, the language of audio or text)
        /// </summary>
        public string Culture { get; set; }

        /// <summary>
        /// Path to media file.
        /// (Actually a Key for CulturedMedia resource)
        /// </summary>
        public string PathKey { get; set; }

        /// <summary>
        /// Type of path.
        /// </summary>
        public PathType PathType { get; set; }

        /// <summary>
        /// Media type. (Video, Audio, application, text)
        /// </summary>
        public MediaType MediaType { get; set; }

        /// <summary>
        /// Media title.
        /// (Actually a Key for CulturedMedia resource)
        /// </summary>
        public string TitleKey { get; set; }

        /// <summary>
        /// Small text about this media.
        /// (Actually a Key for CulturedMedia resource)
        /// </summary>
        public string TextKey { get; set; }

        /// <summary>
        /// Momentum related to this media.
        /// </summary>
        public virtual Momentum Momentum { get; set; }
    }
}
