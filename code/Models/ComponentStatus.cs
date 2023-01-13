using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stasis.AI.Models
{
    internal enum DamageStatus
    {
        None = 0,
        Damaged = 1,
        Destroyed = 2
    }

    internal enum PowerStatus
    {
        Online = 0,
        Intermittent = 1,
        Offline = 2
    }
}
