namespace DMData.Stats
{
    public sealed class Ability
    {
        public AbilityCategoryType Category { get; private set; }
        public string FullName { get; private set; }
        public string Abbreviation { get; private set; }
        public int BaseScore { get; private set; }

        public Ability(AbilityCategoryType category, string fullName, string abbreviation)
        {
            this.Category = category;
            this.FullName = fullName;
            this.Abbreviation = abbreviation;
            this.BaseScore = 8;
        }

        public bool SetBaseScore(int score)
        {
            if (AbilityScore.IsValidScore(score))
            {
                this.BaseScore = score;
                return true;
            }
            else { return false; }
        }
    }
}
