using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMData.Stats
{
    public interface IRace
    {
        IReadOnlyList<MovementInfo> MovementList { get; }
        IReadOnlyList<LangaugeInfo> LanguageList { get; }
        IReadOnlyList<AbilityAdjustment> AbilityAdjustmentList { get; }

        int AgeMax { get; }
        int AgeMin { get; }
        SizeCategoryType SizeCategory { get; }
    }
}
