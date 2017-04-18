using Brambillator.Infrastructure.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brambillator.Historiarum.Domain.Model
{
    /// <summary>
    /// Source for an information.
    /// Ex: Historiarum WebSite, Google, Facebook, Editor...
    /// </summary>
    public class System : Entity
    {
        /// <summary>
        /// System name
        /// </summary>
        public string Name { get; set; }
    }
}
