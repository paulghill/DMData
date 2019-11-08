using System;

namespace DMData
{
    public struct Level : IEquatable<Level>
    {
        public double LevelValue { get; private set; }
        public int ProficiencyBonus { get; private set; }
        public int MinHP { get; private set; }
        public int MaxHP { get; private set; }
        public int MinDamage { get; private set; }
        public int MaxDamage { get; private set; }
        public int LevelXP { get; private set; }
        public int CRXP { get; private set; }

        public Level(double level, int bonus, int minHP, int maxHP, int minDamage, int maxDamage, int levelXP, int crXP)
        {
            this.LevelValue = level;
            this.ProficiencyBonus = bonus;
            this.MaxHP = maxHP;
            this.MinHP = minHP;
            this.MinDamage = minDamage;
            this.MaxDamage = maxDamage;
            this.LevelXP = levelXP;
            this.CRXP = crXP;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType())) { return false; }
            else { return this.Equals((Level)obj); }
        }
        public bool Equals(Level other)
        {
            return (this.CRXP == other.CRXP) &&
                (this.LevelValue == other.LevelValue) &&
                (this.LevelXP == other.LevelXP) &&
                (this.MaxDamage == other.MaxDamage) &&
                (this.MaxHP == other.MaxHP) &&
                (this.MinDamage == other.MinDamage) &&
                (this.MinHP == other.MinHP) &&
                (this.ProficiencyBonus == other.ProficiencyBonus);
        }

        public override int GetHashCode()
        {
            return Tuple.Create(this.LevelValue, this.ProficiencyBonus, this.MinDamage, this.MinHP, this.MaxDamage, this.MaxHP, this.LevelXP, this.CRXP).GetHashCode();
        }

        public static bool operator ==(Level left, Level right)
        {
            return left.Equals(right);
        }
        public static bool operator !=(Level left, Level right)
        {
            return !(left == right);
        }
    }
}
