using System.Collections.Generic;
using System.Linq;


namespace DMData
{
    public static class Info
    {
        public static Dictionary<AlignmentType, string> Alignments => new Dictionary<AlignmentType, string>
                {
                    { AlignmentType.ChaoticEvil, "Chaotic Evil" },
                    { AlignmentType.ChaoticGood, "Chaotic Good" },
                    { AlignmentType.ChaoticNeutral, "Chaotic Neutral" },
                    { AlignmentType.LawfulEvil, "Lawful Evil" },
                    { AlignmentType.LawfulGood, "Lawful Good" },
                    { AlignmentType.LawfulNeutral, "Lawful Neutral" },
                    { AlignmentType.Neutral, "Neutral" },
                    { AlignmentType.NeutralEvil, "Neutral Evil" },
                    { AlignmentType.NeutralGood, "Neutral Good" },
                    { AlignmentType.Unaligned, "Unaligned" }
                };
        public static Dictionary<int, int> AbilityModifiers => new Dictionary<int, int>
                {
                    {1,-5},
                    {2,-4},
                    {3,-4},
                    {4,-3},
                    {5,-3},
                    {6,-2},
                    {7,-2},
                    {8,-1},
                    {9,-1},
                    {10,0},
                    {11,0},
                    {12,1},
                    {13,1},
                    {14,2},
                    {15,2},
                    {16,3},
                    {17,3},
                    {18,4},
                    {19,4},
                    {20,5},
                    {21,5},
                    {22,6},
                    {23,6},
                    {24,7},
                    {25,7},
                    {26,8},
                    {27,8},
                    {28,9},
                    {29,9},
                    {30,10},
                };
        public static IReadOnlyList<Level> LevelList => new List<Level>()
        {
            new Level(0,2,1,6,0,1,0,0),
            new Level(.125,2,7,35,2,3,0,25),
            new Level(.25,2,36,49,4,5,0,50),
            new Level(.5,2,50,70,6,8,0,100),
            new Level(1,2,71,85,9,14,0,200),
            new Level(2,2,86,100,15,20,300,450),
            new Level(3,2,101,115,21,26,900,700),
            new Level(4,2,116,130,27,32,2700,1100),
            new Level(5,3,131,145,33,38,6500,1800),
            new Level(6,3,146,160,39,44,14000,2300),
            new Level(7,3,161,175,45,50,23000,2900),
            new Level(8,3,176,190,51,56,34000,3900),
            new Level(9,4,191,205,57,62,48000,5000),
            new Level(10,4,206,220,63,68,64000,5900),
            new Level(11,4,221,235,69,74,85000,7200),
            new Level(12,4,236,250,75,80,100000,8400),
            new Level(13,5,251,265,81,86,120000,10000),
            new Level(14,5,226,280,87,92,140000,11500),
            new Level(15,5,281,295,93,98,165000,13000),
            new Level(16,5,296,310,99,104,195000,15000),
            new Level(17,6,311,325,105,110,225000,18000),
            new Level(18,6,326,340,111,116,265000,20000),
            new Level(19,6,341,335,117,122,305000,22000),
            new Level(20,6,356,400,123,140,355000,25000),
            new Level(21,7,401,445,141,158,0,33000),
            new Level(22,7,446,490,159,176,0,41000),
            new Level(23,7,491,535,177,194,0,50000),
            new Level(24,7,536,580,195,212,0,62000),
            new Level(25,8,581,625,213,230,0,75000),
            new Level(26,8,626,670,231,248,0,90000),
            new Level(27,8,671,715,249,266,0,105000),
            new Level(28,8,716,760,267,284,0,120000),
            new Level(29,9,761,805,285,302,0,135000),
            new Level(30,9,806,850,303,320,0,155000),
        };
        public static IReadOnlyList<Language> LanguageList => new List<Language>()
                {
                    new Language(LanguageType.Abyssal, LanguageType.Infernal, CampaignType.Standard, "Abyssal", true),
                    new Language(LanguageType.Celestial, LanguageType.Celestial, CampaignType.Standard, "Celestial", true),
                    new Language(LanguageType.Draconic, LanguageType.Draconic, CampaignType.Standard, "Draconic", true),
                    new Language(LanguageType.DeepSpeech, LanguageType.None, CampaignType.Standard, "Deep Speech", true),
                    new Language(LanguageType.Infernal, LanguageType.Infernal, CampaignType.Standard, "Infernal", true),
                    new Language(LanguageType.Primordial, LanguageType.Dwarvish, CampaignType.Standard, "Primordial", true),
                    new Language(LanguageType.Sylvan, LanguageType.Elvish, CampaignType.Standard, "Sylvan", true),
                    new Language(LanguageType.Undercommon, LanguageType.Elvish, CampaignType.Standard, "Undercommon", true),
                    new Language(LanguageType.Aquan, LanguageType.Dwarvish, CampaignType.Standard, "Aquan", true),
                    new Language(LanguageType.Auran, LanguageType.Dwarvish, CampaignType.Standard, "Auran", true),
                    new Language(LanguageType.Igan, LanguageType.Dwarvish, CampaignType.Standard, "Igan", true),
                    new Language(LanguageType.Terran, LanguageType.Dwarvish, CampaignType.Standard, "Terran", true),
                    new Language(LanguageType.Common, LanguageType.Common, CampaignType.Standard, "Common", false),
                    new Language(LanguageType.Druidic, LanguageType.Druidic, CampaignType.Standard, "Druidic", false),
                    new Language(LanguageType.Dwarvish, LanguageType.Dwarvish, CampaignType.Standard, "Dwarvish", false),
                    new Language(LanguageType.Elvish, LanguageType.Elvish, CampaignType.Standard, "Elvish", false),
                    new Language(LanguageType.Giant, LanguageType.Dwarvish, CampaignType.Standard, "Giant", false),
                    new Language(LanguageType.Gnomish, LanguageType.Dwarvish, CampaignType.Standard, "Gnomish",false),
                    new Language(LanguageType.Goblin, LanguageType.Dwarvish, CampaignType.Standard, "Goblin", false),
                    new Language(LanguageType.Halfling, LanguageType.Common, CampaignType.Standard, "Halfling", false),
                    new Language(LanguageType.Orc, LanguageType.Dwarvish, CampaignType.Standard, "Orc", false),
                };

        public static string GetAlignmentDisplayName(AlignmentType type) 
        {
            if (Alignments.TryGetValue(type, out string output)) { return output; }
            else { return ""; }
        }
        public static Level GetLevel(double level)
        {
            if (LevelList.Any(a => a.LevelValue == level)) 
            {
                return LevelList.Where(a => a.LevelValue == level).First();
            }
            else { return LevelList[0]; }
        }
        public static int GetAbilityModifier(int abilityScore)
        {
            if (AbilityModifiers.TryGetValue(abilityScore, out int modifier)) { return modifier; }
            else { return 0; }
        }

        public static bool ValidateAbilityScore(int abilityScore)
        {
            if (AbilityModifiers.TryGetValue(abilityScore, out _)) { return true; }
            else { return false; }
        }
    }
}
