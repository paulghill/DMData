using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DMData.Stats
{
    public struct AbilityScore : IEquatable<AbilityScore>
    {
        public static IReadOnlyList<AbilityScore> ModifierList => new List<AbilityScore>()
        {
            new AbilityScore(1,-5),
            new AbilityScore(2,-4),
            new AbilityScore(3,-4),
            new AbilityScore(4,-3),
            new AbilityScore(5,-3),
            new AbilityScore(6,-2),
            new AbilityScore(7,-2),
            new AbilityScore(8,-1),
            new AbilityScore(9,-1),
            new AbilityScore(10,0),
            new AbilityScore(11,0),
            new AbilityScore(12,1),
            new AbilityScore(13,1),
            new AbilityScore(14,2),
            new AbilityScore(15,2),
            new AbilityScore(16,3),
            new AbilityScore(17,3),
            new AbilityScore(18,4),
            new AbilityScore(19,4),
            new AbilityScore(20,5),
            new AbilityScore(21,5),
            new AbilityScore(22,6),
            new AbilityScore(23,6),
            new AbilityScore(24,7),
            new AbilityScore(25,7),
            new AbilityScore(26,8),
            new AbilityScore(27,8),
            new AbilityScore(28,9),
            new AbilityScore(29,9),
            new AbilityScore(30,10),
        };

        public int Score { get; private set; }
        public int Modifier { get; private set; }

        public AbilityScore(int score, int modifier)
        {
            this.Score = score;
            this.Modifier = modifier;
        }

        public static int Get(int score)
        {
            return ModifierList.Where(a => a.Score == score).First().Modifier;
        }
        public static int GetScoreLow()
        {
            return ModifierList.OrderBy(a => a.Score).First().Score;
        }
        public static int GetScoreHigh()
        {
            return ModifierList.OrderBy(a => a.Score).Last().Score;
        }

        public static bool IsValidScore(int score)
        {
            if (score >= AbilityScore.GetScoreHigh() && score <= AbilityScore.GetScoreHigh()) { return true; }
            else { return false; }
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType())) { return false; }
            else { return this.Equals((AbilityScore)obj); }
        }
        public bool Equals(AbilityScore other)
        {
            return (this.Score == other.Score) && (this.Modifier == other.Modifier);
        }

        public override int GetHashCode()
        {
            return Tuple.Create(this.Score, this.Modifier).GetHashCode();
        }

        public static bool operator ==(AbilityScore left, AbilityScore right)
        {
            return left.Equals(right);
        }
        public static bool operator !=(AbilityScore left, AbilityScore right)
        {
            return !(left == right);
        }
    }
    public struct AbilityAdjustment : IEquatable<AbilityAdjustment>
    {
        public string Name { get; private set; }
        public AbilityCategoryType Category { get; private set; }
        public int Modifier { get; private set; }

        public AbilityAdjustment(string name, AbilityCategoryType category, int modifier)
        {
            this.Name = name;
            this.Category = category;
            this.Modifier = modifier;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType())) { return false; }
            else { return this.Equals((AbilityAdjustment)obj); }
        }
        public bool Equals(AbilityAdjustment other)
        {
            return (this.Category == other.Category) &&
                (this.Modifier == other.Modifier) &&
                (this.Name == other.Name);
        }

        public override int GetHashCode()
        {
            return Tuple.Create(this.Name, this.Category, this.Modifier).GetHashCode();
        }

        public static bool operator ==(AbilityAdjustment left, AbilityAdjustment right)
        {
            return left.Equals(right);
        }
        public static bool operator !=(AbilityAdjustment left, AbilityAdjustment right)
        {
            return !(left == right);
        }
    }

    public struct LevelInfo : IEquatable<LevelInfo>
    {
        public static IReadOnlyList<LevelInfo> LevelInfoList => new List<LevelInfo>()
        {
            new LevelInfo(LevelType.L0,2,1,6,0,1,0,0),
            new LevelInfo(LevelType.LEigth,2,7,35,2,3,0,25),
            new LevelInfo(LevelType.LQuarter,2,36,49,4,5,0,50),
            new LevelInfo(LevelType.LHalf,2,50,70,6,8,0,100),
            new LevelInfo(LevelType.L1,2,71,85,9,14,0,200),
            new LevelInfo(LevelType.L2,2,86,100,15,20,300,450),
            new LevelInfo(LevelType.L3,2,101,115,21,26,900,700),
            new LevelInfo(LevelType.L4,2,116,130,27,32,2700,1100),
            new LevelInfo(LevelType.L5,3,131,145,33,38,6500,1800),
            new LevelInfo(LevelType.L6,3,146,160,39,44,14000,2300),
            new LevelInfo(LevelType.L7,3,161,175,45,50,23000,2900),
            new LevelInfo(LevelType.L8,3,176,190,51,56,34000,3900),
            new LevelInfo(LevelType.L9,4,191,205,57,62,48000,5000),
            new LevelInfo(LevelType.L10,4,206,220,63,68,64000,5900),
            new LevelInfo(LevelType.L11,4,221,235,69,74,85000,7200),
            new LevelInfo(LevelType.L12,4,236,250,75,80,100000,8400),
            new LevelInfo(LevelType.L13,5,251,265,81,86,120000,10000),
            new LevelInfo(LevelType.L14,5,226,280,87,92,140000,11500),
            new LevelInfo(LevelType.L15,5,281,295,93,98,165000,13000),
            new LevelInfo(LevelType.L16,5,296,310,99,104,195000,15000),
            new LevelInfo(LevelType.L17,6,311,325,105,110,225000,18000),
            new LevelInfo(LevelType.L18,6,326,340,111,116,265000,20000),
            new LevelInfo(LevelType.L19,6,341,335,117,122,305000,22000),
            new LevelInfo(LevelType.L20,6,356,400,123,140,355000,25000),
            new LevelInfo(LevelType.L21,7,401,445,141,158,0,33000),
            new LevelInfo(LevelType.L22,7,446,490,159,176,0,41000),
            new LevelInfo(LevelType.L23,7,491,535,177,194,0,50000),
            new LevelInfo(LevelType.L24,7,536,580,195,212,0,62000),
            new LevelInfo(LevelType.L25,8,581,625,213,230,0,75000),
            new LevelInfo(LevelType.L26,8,626,670,231,248,0,90000),
            new LevelInfo(LevelType.L27,8,671,715,249,266,0,105000),
            new LevelInfo(LevelType.L28,8,716,760,267,284,0,120000),
            new LevelInfo(LevelType.L29,9,761,805,285,302,0,135000),
            new LevelInfo(LevelType.L30,9,806,850,303,320,0,155000),
        };

        public LevelType Level { get; private set; }
        public int ProficiencyBonus { get; private set; }
        public int MinHP { get; private set; }
        public int MaxHP { get; private set; }
        public int MinDamage { get; private set; }
        public int MaxDamage { get; private set; }
        public int LevelXP { get; private set; }
        public int CRXP { get; private set; }

        public LevelInfo(LevelType level, int bonus, int minHP, int maxHP, int minDamage, int maxDamage, int levelXP, int crXP)
        {
            this.Level = level;
            this.ProficiencyBonus = bonus;
            this.MaxHP = maxHP;
            this.MinHP = minHP;
            this.MinDamage = minDamage;
            this.MaxDamage = maxDamage;
            this.LevelXP = levelXP;
            this.CRXP = crXP;
        }

        public static LevelInfo Get(LevelType level)
        {
            if (LevelInfo.LevelInfoList.Any(a => a.Level == level))
            {
                return LevelInfoList.Where(a => a.Level == level).First();
            }
            else { return LevelInfo.LevelInfoList[0]; }
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType())) { return false; }
            else { return this.Equals((LevelInfo)obj); }
        }
        public bool Equals(LevelInfo other)
        {
            return (this.CRXP == other.CRXP) &&
                (this.Level == other.Level) &&
                (this.LevelXP == other.LevelXP) &&
                (this.MaxDamage == other.MaxDamage) &&
                (this.MaxHP == other.MaxHP) &&
                (this.MinDamage == other.MinDamage) &&
                (this.MinHP == other.MinHP) &&
                (this.ProficiencyBonus == other.ProficiencyBonus);
        }

        public override int GetHashCode()
        {
            return Tuple.Create(this.Level, this.ProficiencyBonus, this.MinDamage, this.MinHP, this.MaxDamage, this.MaxHP, this.LevelXP, this.CRXP).GetHashCode();
        }

        public static bool operator ==(LevelInfo left, LevelInfo right)
        {
            return left.Equals(right);
        }
        public static bool operator !=(LevelInfo left, LevelInfo right)
        {
            return !(left == right);
        }
    }
    
    public struct MovementAdjustment : IEquatable<MovementAdjustment>
    {
        public MovementCategoryType Category { get; private set; }
        public int Adjustment { get; private set; }
        public string Name { get; private set; }

        public MovementAdjustment(MovementCategoryType category, int adjustment, string name)
        {
            this.Category = category;
            this.Adjustment = adjustment;
            this.Name = name;
        }
        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType())) { return false; }
            else { return this.Equals((MovementAdjustment)obj); }
        }
        public bool Equals(MovementAdjustment other)
        {
            return (this.Category == other.Category) &&
                (this.Adjustment == other.Adjustment) &&
                (this.Name == other.Name);
        }

        public override int GetHashCode()
        {
            return Tuple.Create(this.Name, this.Category, this.Adjustment).GetHashCode();
        }

        public static bool operator ==(MovementAdjustment left, MovementAdjustment right)
        {
            return left.Equals(right);
        }
        public static bool operator !=(MovementAdjustment left, MovementAdjustment right)
        {
            return !(left == right);
        }
    }
    public struct Movement : IEquatable<Movement>
    {
        public MovementCategoryType Category { get; private set; }
        public int Speed { get; private set; }

        public Movement(MovementCategoryType category, int speed)
        {
            this.Category = category;
            this.Speed = speed;
        }

        public string GetDisplayMovementValue()
        {
            var output = new StringBuilder();
            output.Append(this.Speed);
            output.Append("ft. ");
            output.Append(this.Category);

            return output.ToString();
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType())) { return false; }
            else { return this.Equals((Movement)obj); }
        }
        public bool Equals(Movement other)
        {
            return (this.Category == other.Category) && (this.Speed == this.Speed);
        }

        public override int GetHashCode()
        {
            return Tuple.Create(this.Category, this.Speed).GetHashCode();
        }

        public static bool operator ==(Movement left, Movement right)
        {
            return left.Equals(right);
        }
        public static bool operator !=(Movement left, Movement right)
        {
            return !(left == right);
        }
    }

    public struct SavingThrowModifier : IEquatable<SavingThrowModifier>
    {
        public AbilityCategoryType Category { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }

        public SavingThrowModifier(AbilityCategoryType category, string name, string description)
        {
            this.Category = category;
            this.Name = name;
            this.Description = description;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType())) { return false; }
            else { return this.Equals((SavingThrowModifier)obj); }
        }
        public bool Equals(SavingThrowModifier other)
        {
            return this.Name == other.Name &&
                this.Category == other.Category &&
                this.Description == other.Description;
        }

        public override int GetHashCode()
        {
            return Tuple.Create(this.Category, this.Name, this.Description).GetHashCode();
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
