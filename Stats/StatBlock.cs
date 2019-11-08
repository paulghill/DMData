using DMData.Abilities;

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
        //public AlignmentInfo Alignment { get; private set; }

        public StatBlock(AlignmentType alignment)
        {
            this.Abilities = new AbilityBlock();
            //this.Alignment = AlignmentInfo.GetAlignment(alignment);
        }
    }
}
