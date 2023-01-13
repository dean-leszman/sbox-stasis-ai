using Stasis.AI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stasis.AI.Modules
{
    internal class Component
    {
        public Component( string name, DamageStatus dmg, PowerStatus pwr ) : this( name )
        {
            DamageStatus = dmg;
            PowerStatus= pwr;
        }

        public Component( string name ) : this()
        {
            Name = name;
        }

        public Component()
        {
            DamageStatus = DamageStatus.None;
            PowerStatus = PowerStatus.Offline;
        }

        /// <summary>
        /// Component name
        /// </summary>
        public string Name { get; set; }

        public DamageStatus DamageStatus { get; set; }

        public PowerStatus PowerStatus { get; set; }
    }
}
