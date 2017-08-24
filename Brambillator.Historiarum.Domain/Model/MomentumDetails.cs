using Brambillator.Infrastructure.Domain.Models;

namespace Brambillator.Historiarum.Domain.Model
{
    public class MomentumDetail : Entity
    {
        public virtual Momentum Momentum { get; set; }
        public string Culture { get; set; }
        public string HeadLine { get; set; }
        public string ShortText { get; set; }
    }
}
