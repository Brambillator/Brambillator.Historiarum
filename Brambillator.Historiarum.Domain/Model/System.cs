﻿using Brambillator.Infrastructure.Domain.Models;

namespace Brambillator.Historiarum.Domain.Model
{
    /// <summary>
    /// Source for an information.
    /// Ex: Historiarum WebSite, Google, Facebook, Editor...
    /// </summary>
    public class System : Entity
    {
        /// <summary>
        /// Unique identifier.
        /// </summary>
        public string Key { get; set; }
        
        /// <summary>
        /// System name.
        /// </summary>
        public string Name { get; set; }
    }
}
