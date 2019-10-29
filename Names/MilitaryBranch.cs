using System.Collections.Generic;
using System.Linq;

namespace DMData.Names
{
    public sealed class MilitaryBranch
    {
        public MilitaryCategoryType Category { get; private set; }
        public MilitaryBranchType Branch { get; private set; }
        public IReadOnlyList<MilitaryRank> RanksCombined { get; private set; }

        public IReadOnlyList<MilitaryRank> OfficerRanks => RanksCombined
#pragma warning disable CA1307 // Specify StringComparison
            .Where(a => a.Grade.ToString().StartsWith("O") || a.Grade.ToString().StartsWith("W") || a.Grade.ToString().StartsWith("U"))
            .ToList();
#pragma warning restore CA1307 // Specify StringComparison
        public IReadOnlyList<MilitaryRank> EnlistedRanks => RanksCombined
#pragma warning disable CA1307 // Specify StringComparison
            .Where(a => a.Grade.ToString().StartsWith("E") || a.Grade.ToString().StartsWith("U"))
            .ToList();
#pragma warning restore CA1307 // Specify StringComparison

        public MilitaryBranch(MilitaryCategoryType categoryType, MilitaryBranchType branchType, IReadOnlyList<MilitaryRank> data)
        {
            this.Category = categoryType;
            this.Branch = branchType;
            this.RanksCombined = data;
        }
    }
}
