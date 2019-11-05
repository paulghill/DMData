using System.Collections.Generic;

namespace DMData.Names
{
    internal static partial class DataNames
    {
        public static IReadOnlyList<CategoryNames> Names = new List<CategoryNames>()
        {
            new CategoryNames(NameCategoryType.Arabic, ArabicFemaleNames, ArabicMaleNames),
            new CategoryNames(NameCategoryType.Chinese, ChineseFemaleNames, ChineseMaleNames, ChineseSurnames),
            new CategoryNames(NameCategoryType.Czech, CzechFemaleNames, CzechMaleNames, CzechSurnames),
            new CategoryNames(NameCategoryType.Danish, DanishFemaleNames, DanishMaleNames, DanishSurnames),
            new CategoryNames(NameCategoryType.Dragonborn, DragonbornFemaleNames, DragonbornMaleNames, DragonbornSurnames),
            new CategoryNames(NameCategoryType.Dutch, DutchFemaleNames, DutchMaleNames, DutchSurnames),
            new CategoryNames(NameCategoryType.Dwarf, DwarfFemaleNames, DwarfMaleNames, DwarfSurnames),
            new CategoryNames(NameCategoryType.Egyptian, EgyptianFemaleNames, EgyptianMaleNames),
            new CategoryNames(NameCategoryType.Elf, ElfFemaleNames, ElfMaleNames, ElfSurnames),
            new CategoryNames(NameCategoryType.English, EnglishFemaleNames, EnglishMaleNames, EnglishSurnames),
            new CategoryNames(NameCategoryType.Finnish, FinnishFemaleNames, FinnishMaleNames, FinnishSurnames),
            new CategoryNames(NameCategoryType.French, FrenchFemaleNames, FrenchMaleNames, FrenchSurnames),
            new CategoryNames(NameCategoryType.German, GermanFemaleNames, GermanMaleNames, GermanSurnames),
            new CategoryNames(NameCategoryType.Gnome, GnomeFemaleNames, GnomeMaleNames, GnomeSurnames),
            new CategoryNames(NameCategoryType.Greek, GreekFemaleNames, GreekMaleNames),
            new CategoryNames(NameCategoryType.Halfling, HalflingFemaleNames, HalflingMaleNames, HalflingSurnames),
            new CategoryNames(NameCategoryType.HalfOrc, HalfOrcFemaleNames, HalfOrcMaleNames),
            new CategoryNames(NameCategoryType.Icelandic, IcelandicFemaleNames, IcelandicMaleNames),
            new CategoryNames(NameCategoryType.Indian, IndianFemaleNames, IndianMaleNames, IndianSurnames),
            new CategoryNames(NameCategoryType.Irish, IrishFemaleNames, IrishMaleNames, IrishSurnames),
            new CategoryNames(NameCategoryType.Italian, ItailianFemaleNames, ItailianMaleNames, ItailianSurnames),
            new CategoryNames(NameCategoryType.Japanese, JapaneseFemaleNames, JapaneseMaleNames, JapaneseSurnames),
            new CategoryNames(NameCategoryType.Korean, KoreanFemaleNames, KoreanMaleNames),
            new CategoryNames(NameCategoryType.Mesoamerican, MesoamericanFemaleNames, MesoamericanMaleNames),
            new CategoryNames(NameCategoryType.NigerCongo, NigerCongoFemaleNames, NigerCongoMaleNames),
            new CategoryNames(NameCategoryType.Polynesian, PolynesianFemaleNames, PolynesianMaleNames),
            new CategoryNames(NameCategoryType.Portuguese, PortugueseFemaleNames, PortugueseMaleNames, PortugueseSurnames),
            new CategoryNames(NameCategoryType.Roman, RomanFemaleNames, RomanMaleNames),
            new CategoryNames(NameCategoryType.Scottish, ScottishFemaleNames, ScottishMaleNames, ScottishSurnames),
            new CategoryNames(NameCategoryType.Slavic, SlavicFemaleNames, SlavicMaleNames, SlavicSurnames),
            new CategoryNames(NameCategoryType.Spanish, SpanishFemaleNames, SpanishMaleNames, SpanishSurnames),
            new CategoryNames(NameCategoryType.Swedish, SwedishFemaleNames, SwedishMaleNames, SwedishSurnames),
            new CategoryNames(NameCategoryType.Tiefling, TieflingFemaleNames, TieflingMaleNames),
            new CategoryNames(NameCategoryType.Turkish, TurkishFemaleNames, TurkishMaleNames),
            new CategoryNames(NameCategoryType.Welsh, WelshFemaleNames, WelshMaleNames),
        };

    }
}
