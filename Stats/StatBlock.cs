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
        public AlignmentInfo Alignment { get; private set; }

        public StatBlock(AlignmentType alignment)
        {
            this.Abilities = new AbilityBlock();
            this.Alignment = AlignmentInfo.GetAlignment(alignment);
        }

        public int LongJump() { return this.Abilities.GetAdjustedScore(AbilityCategoryType.Strength); }
        public int LongJumpStanding()
        {
            double output = this.LongJump() / 2;
            return (int)Math.Round(output, 0, MidpointRounding.ToEven);
        }
        public int HighJump() { return 3 + this.Abilities.GetAdjustedModifier(AbilityCategoryType.Strength); }
        public int HighJumpStanding() 
        {
            double output = this.HighJump() / 2;
            return (int)Math.Round(output, 0, MidpointRounding.ToEven);
        }
    }
}
