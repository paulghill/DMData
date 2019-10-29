using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMData.Stats
{
    public sealed class StatBlock
    {
        public AbilityBlock Abilities { get; private set; }

        public StatBlock()
        {
            this.Abilities = new AbilityBlock();
        }
    }
}
