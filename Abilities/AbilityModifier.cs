using System;


namespace DMData.Abilities
{
    public struct AbilityModifier : IEquatable<AbilityModifier>
    {
        public string Name { get; private set; }
        public AbilityCategoryType Category { get; private set; }
        public int Adjustment { get; private set; }

        public AbilityModifier(string name, AbilityCategoryType category, int modifier)
        {
            this.Name = name;
            this.Category = category;
            this.Adjustment = modifier;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType())) { return false; }
            else { return this.Equals((AbilityModifier)obj); }
        }
        public bool Equals(AbilityModifier other)
        {
            return (this.Category == other.Category) &&
                (this.Adjustment == other.Adjustment) &&
                (this.Name == other.Name);
        }

        public override int GetHashCode()
        {
            return Tuple.Create(this.Name, this.Category, this.Adjustment).GetHashCode();
        }

        public static bool operator ==(AbilityModifier left, AbilityModifier right)
        {
            return left.Equals(right);
        }
        public static bool operator !=(AbilityModifier left, AbilityModifier right)
        {
            return !(left == right);
        }
    }
}
