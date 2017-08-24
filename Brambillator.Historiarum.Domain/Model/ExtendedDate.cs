using Brambillator.Infrastructure.Domain.Models;
using Brambillator.Historiarum.Domain.Lookups;
using System;

namespace Brambillator.Historiarum.Domain.Model
{
    public class ExtendedDate : Entity
    {
        public ExtendedDate()
        {

        }

        public ExtendedDate(DateTime dateTime)
        {
            Scale = TimeScale.DateTime;
            Amount = dateTime.Ticks;
        }

        /// <summary>
        /// Amount of units in referenced scale. If Scale equals DateTime then Amount equals DateTime.Ticks
        /// </summary>
        public long Amount;

        /// <summary>
        /// Scale of the amount units.
        /// </summary>
        public TimeScale Scale;
    }
}
