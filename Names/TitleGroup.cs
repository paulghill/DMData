using System.Collections.Generic;

namespace DMData.Names
{
    public sealed class TitleGroup
    {
        public TitleCategoryType Category { get; private set; }
        public IReadOnlyList<Title> Titles { get; private set; }

        public TitleGroup(TitleCategoryType category, IReadOnlyList<Title> titles)
        {
            this.Category = category;
            this.Titles = titles;
        }
    }
}
