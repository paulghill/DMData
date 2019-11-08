using System;

namespace DMData.Abilities
{
    public struct SavingThrowModifier : IEquatable<SavingThrowModifier>
    {
        public AbilityCategoryType Category { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }

        public SavingThrowModifier(AbilityCategoryType category, string name, string description)
        {
            Category = category;
            Name = name;
            Description = description;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !GetType().Equals(obj.GetType())) { return false; }
            else { return Equals((SavingThrowModifier)obj); }
        }
        public bool Equals(SavingThrowModifier other)
        {
            return Name == other.Name &&
                Category == other.Category &&
                Description == other.Description;
        }

        public override int GetHashCode()
        {
            return Tuple.Create(Category, Name, Description).GetHashCode();
        }

        public static bool operator ==(SavingThrowModifier left, SavingThrowModifier right)
        {
            return left.Equals(right);
        }
        public static bool operator !=(SavingThrowModifier left, SavingThrowModifier right)
        {
            return !(left == right);
        }
    }
}