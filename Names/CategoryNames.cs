using System.Collections.Generic;

namespace DMData.Names
{
    public sealed class CategoryNames
    {
        public NameCategoryType Category { get; private set; }
        public bool HasSurnames { get; private set; }
        public IReadOnlyList<string> FemaleNames { get; private set; }
        public IReadOnlyList<string> MaleNames { get; private set; }
        public IReadOnlyList<string> Surnames { get; private set; }

        public CategoryNames(NameCategoryType categoryType, IReadOnlyList<string> femaleNames, IReadOnlyList<string> maleNames)
        {
            this.Category = categoryType;
            this.HasSurnames = false;
            this.FemaleNames = femaleNames;
            this.MaleNames = maleNames;
        }
        public CategoryNames(NameCategoryType categoryType, IReadOnlyList<string> femaleNames, IReadOnlyList<string> maleNames, IReadOnlyList<string> surnames)
        {
            this.Category = categoryType;
            this.HasSurnames = true;
            this.FemaleNames = femaleNames;
            this.MaleNames = maleNames;
            this.Surnames = surnames;
        }

    }
}
