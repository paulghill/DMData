using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DMData.Stats
{
    public struct AbilityScoreInfo : IEquatable<AbilityScoreInfo>
    {
        public static IReadOnlyList<AbilityScoreInfo> ModifierList => new List<AbilityScoreInfo>()
        {
            new AbilityScoreInfo(1,-5),
            new AbilityScoreInfo(2,-4),
            new AbilityScoreInfo(3,-4),
            new AbilityScoreInfo(4,-3),
            new AbilityScoreInfo(5,-3),
            new AbilityScoreInfo(6,-2),
            new AbilityScoreInfo(7,-2),
            new AbilityScoreInfo(8,-1),
            new AbilityScoreInfo(9,-1),
            new AbilityScoreInfo(10,0),
            new AbilityScoreInfo(11,0),
            new AbilityScoreInfo(12,1),
            new AbilityScoreInfo(13,1),
            new AbilityScoreInfo(14,2),
            new AbilityScoreInfo(15,2),
            new AbilityScoreInfo(16,3),
            new AbilityScoreInfo(17,3),
            new AbilityScoreInfo(18,4),
            new AbilityScoreInfo(19,4),
            new AbilityScoreInfo(20,5),
            new AbilityScoreInfo(21,5),
            new AbilityScoreInfo(22,6),
            new AbilityScoreInfo(23,6),
            new AbilityScoreInfo(24,7),
            new AbilityScoreInfo(25,7),
            new AbilityScoreInfo(26,8),
            new AbilityScoreInfo(27,8),
            new AbilityScoreInfo(28,9),
            new AbilityScoreInfo(29,9),
            new AbilityScoreInfo(30,10),
        };

        public int Score { get; private set; }
        public int Modifier { get; private set; }

        public AbilityScoreInfo(int score, int modifier)
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
            if (score >= AbilityScoreInfo.GetScoreHigh() && score <= AbilityScoreInfo.GetScoreHigh()) { return true; }
            else { return false; }
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType())) { return false; }
            else { return this.Equals((AbilityScoreInfo)obj); }
        }
        public bool Equals(AbilityScoreInfo other)
        {
            return (this.Score == other.Score) && (this.Modifier == other.Modifier);
        }

        public override int GetHashCode()
        {
            return Tuple.Create(this.Score, this.Modifier).GetHashCode();
        }

        public static bool operator ==(AbilityScoreInfo left, AbilityScoreInfo right)
        {
            return left.Equals(right);
        }
        public static bool operator !=(AbilityScoreInfo left, AbilityScoreInfo right)
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

    public struct AlignmentInfo : IEquatable<AlignmentInfo>
    {
        static IReadOnlyList<AlignmentInfo> AlignmentList = new List<AlignmentInfo>() 
        {
            new AlignmentInfo(AlignmentType.ChaoticEvil, "Chaotic Evil"),
            new AlignmentInfo(AlignmentType.ChaoticGood,"Chaotic Good"),
            new AlignmentInfo(AlignmentType.ChaoticNeutral, "Chaotic Neutral"),
            new AlignmentInfo(AlignmentType.LawfulEvil, "Lawful Evil"),
            new AlignmentInfo(AlignmentType.LawfulGood,"Lawful Good"),
            new AlignmentInfo(AlignmentType.LawfulNeutral,"Lawful Neutral"),
            new AlignmentInfo(AlignmentType.Neutral,"Neutral"),
            new AlignmentInfo(AlignmentType.NeutralEvil, "Neutral Evil"),
            new AlignmentInfo(AlignmentType.NeutralGood, "Neutral Good"),
            new AlignmentInfo(AlignmentType.Unaligned, "Unaligned"),
        };

        public AlignmentType Type { get; private set; }
        public string DisplayName { get; private set; }

        public AlignmentInfo(AlignmentType type, string displayName)
        {
            this.Type = type;
            this.DisplayName = displayName;
        }

        public static AlignmentInfo GetAlignment(AlignmentType type)
        {
            return AlignmentList.Where(a => a.Type == type).First();
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType())) { return false; }
            else { return this.Equals((AlignmentInfo)obj); }
        }
        public bool Equals(AlignmentInfo other)
        {
            return this.DisplayName == other.DisplayName && this.Type == this.Type;
        }

        public override int GetHashCode()
        {
            return Tuple.Create(this.DisplayName, this.Type).GetHashCode();
        }

        public static bool operator ==(AlignmentInfo left, AlignmentInfo right)
        {
            return left.Equals(right);
        }
        public static bool operator !=(AlignmentInfo left, AlignmentInfo right)
        {
            return !(left == right);
        }
    }

    public struct LangaugeInfo : IEquatable<LangaugeInfo>
    {
        static IReadOnlyList<LangaugeInfo> LanguageList = new List<LangaugeInfo>() 
        { 
            new LangaugeInfo(LanguageType.Abyssal, LangauageCategoryType.Standard, "Abyssal"),
            new LangaugeInfo(LanguageType.Aquan, LangauageCategoryType.Standard, "Aquan"),
            new LangaugeInfo(LanguageType.Auran, LangauageCategoryType.Standard, "Auran"),
            new LangaugeInfo(LanguageType.Celestial, LangauageCategoryType.Standard, "Celestial"),
            new LangaugeInfo(LanguageType.Common, LangauageCategoryType.Standard, "Common"),
            new LangaugeInfo(LanguageType.DeepSpeech, LangauageCategoryType.Standard, "Deep Speech"),
            new LangaugeInfo(LanguageType.Draconic, LangauageCategoryType.Standard, "Draconic"),
            new LangaugeInfo(LanguageType.Druidic, LangauageCategoryType.Standard, "Druidic"),
            new LangaugeInfo(LanguageType.Dwarvish, LangauageCategoryType.Standard, "Dwarvish"),
            new LangaugeInfo(LanguageType.Elvish, LangauageCategoryType.Standard, "Elvish"),
            new LangaugeInfo(LanguageType.Giant, LangauageCategoryType.Standard, "Giant"),
            new LangaugeInfo(LanguageType.Gnomish, LangauageCategoryType.Standard, "Gnomish"),
            new LangaugeInfo(LanguageType.Goblin, LangauageCategoryType.Standard, "Goblin"),
            new LangaugeInfo(LanguageType.Halfling, LangauageCategoryType.Standard, "Halfling"),
            new LangaugeInfo(LanguageType.Igan, LangauageCategoryType.Standard, "Igan"),
            new LangaugeInfo(LanguageType.Infernal, LangauageCategoryType.Standard, "Infernal"),
            new LangaugeInfo(LanguageType.Orc, LangauageCategoryType.Standard, "Orc"),
            new LangaugeInfo(LanguageType.Primordial, LangauageCategoryType.Standard, "Primordial"),
            new LangaugeInfo(LanguageType.Sylvan, LangauageCategoryType.Standard, "Sylvan"),
            new LangaugeInfo(LanguageType.Terran, LangauageCategoryType.Standard, "Terran"),
            new LangaugeInfo(LanguageType.Undercommon, LangauageCategoryType.Standard, "Undercommon"),
            
        };

        public LanguageType Language { get; private set; }
        public LangauageCategoryType Category { get; private set; }
        public string DisplayName { get; private set; }

        public LangaugeInfo(LanguageType type, LangauageCategoryType category, string displayName)
        {
            this.Language = type;
            this.Category = category;
            this.DisplayName = displayName;
        }

        public static LangaugeInfo GetStandardLanguage(LanguageType language)
        {
            return LanguageList.Where(a => a.Category == LangauageCategoryType.Standard)
                .Where(b => b.Language == language).First();
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType())) { return false; }
            else { return this.Equals((LangaugeInfo)obj); }
        }
        public bool Equals(LangaugeInfo other)
        {
            return this.DisplayName == other.DisplayName && this.Language == other.Language;
        }

        public override int GetHashCode()
        {
            return Tuple.Create(this.DisplayName, this.Language).GetHashCode();
        }

        public static bool operator ==(LangaugeInfo left, LangaugeInfo right)
        {
            return left.Equals(right);
        }
        public static bool operator !=(LangaugeInfo left, LangaugeInfo right)
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
    public struct MovementInfo : IEquatable<MovementInfo>
    {
        public MovementCategoryType Category { get; private set; }
        public int Speed { get; private set; }

        public MovementInfo(MovementCategoryType category, int speed)
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

        public int GetDifficultTerrain()
        {
            double output = this.Speed / 2;
            return (int)Math.Round(output, 0, MidpointRounding.ToEven);
        }
        public int GetSwimmingClimbingCrawling(TerrainType terrain)
        {
            int difficultyMultiplier = 0;

            if (terrain == TerrainType.Normal) { difficultyMultiplier = 2; }
            else { difficultyMultiplier = 3; }

            double output = this.Speed / difficultyMultiplier;
            return (int)Math.Round(output, 0, MidpointRounding.ToEven);
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType())) { return false; }
            else { return this.Equals((MovementInfo)obj); }
        }
        public bool Equals(MovementInfo other)
        {
            return (this.Category == other.Category) && (this.Speed == this.Speed);
        }

        public override int GetHashCode()
        {
            return Tuple.Create(this.Category, this.Speed).GetHashCode();
        }

        public static bool operator ==(MovementInfo left, MovementInfo right)
        {
            return left.Equals(right);
        }
        public static bool operator !=(MovementInfo left, MovementInfo right)
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

    public struct SenseInfo : IEquatable<SenseInfo>
    {
        public SenseType Sense { get; private set; }
        public int Range { get; private set; }
        public bool HasNotes { get; private set; }
        public string Notes { get; private set; }

        public SenseInfo(SenseType sense, int range, string notes)
        {
            this.Sense = sense;
            this.Range = range;
            this.HasNotes = true;
            this.Notes = notes;
        }
        public SenseInfo(SenseType sense, int range)
        {
            this.Sense = sense;
            this.Range = range;
            this.HasNotes = false;
            this.Notes = "";
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType())) { return false; }
            { return this.Equals((SenseInfo)obj); }
        }
        public bool Equals(SenseInfo other)
        {
            return this.Range == other.Range &&
                this.Sense == other.Sense &&
                this.Notes == other.Notes &&
                this.HasNotes == other.HasNotes;
        }

        public override int GetHashCode()
        {
            return Tuple.Create(this.Range, this.Sense, this.HasNotes, this.Notes).GetHashCode();
        }

        public static bool operator ==(SenseInfo left, SenseInfo right)
        {
            return left.Equals(right);
        }
        public static bool operator !=(SenseInfo left, SenseInfo right)
        {
            return !(left == right);
        }
    }
}
