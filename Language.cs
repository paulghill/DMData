using System;


namespace DMData
{
    public struct Language : IEquatable<Language>
    {
        public LanguageType Type { get; private set; }
        public LanguageType Script { get; private set; }
        public CampaignType Campaign { get; private set; }
        public string DisplayName { get; private set; }
        public bool IsExotic { get; private set; }

        public Language(LanguageType type, LanguageType script, CampaignType campaign, string displayName, bool isExotic)
        {
            this.Type = type;
            this.Script = script;
            this.Campaign = campaign;
            this.DisplayName = displayName;
            this.IsExotic = isExotic;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()){ return false; }
            else { return this.Equals((Language)obj); }
        }
        public bool Equals(Language other)
        {
            return this.Campaign == other.Campaign &&
                this.DisplayName == other.DisplayName &&
                this.Type == other.Type &&
                this.Script == other.Script &&
                this.IsExotic == other.IsExotic;
        }

        public override int GetHashCode()
        {
            return Tuple.Create(this.Campaign, this.DisplayName, this.Type, this.IsExotic, this.Script).GetHashCode();
        }

        public static bool operator ==(Language left, Language right)
        {
            return left.Equals(right);
        }
        public static bool operator !=(Language left, Language right)
        {
            return !(left == right);
        }
    }
}
