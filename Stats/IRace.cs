using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMData.Stats
{
    public interface IRace : ISubRace
    {
        int AgeMax { get; }
        int AgeMin { get; }
        SizeCategoryType SizeCategory { get; }

        //IReadOnlyList<MovementInfo> MovementList { get; }
        IReadOnlyList<ISubRace> Subraces { get; }
    }
}
