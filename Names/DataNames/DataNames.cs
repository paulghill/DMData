using System.Collections.Generic;

namespace DMData.Names
{
    internal static partial class DataNames
    {
        public static IReadOnlyList<Name> Names = new List<Name>()
        {
            new Name(NameCategoryType.Arabic, ArabicFemaleNames, ArabicMaleNames),
            new Name(NameCategoryType.Chinese, ChineseFemaleNames, ChineseMaleNames, ChineseSurnames),
            new Name(NameCategoryType.Czech, CzechFemaleNames, CzechMaleNames, CzechSurnames),
            new Name(NameCategoryType.Danish, DanishFemaleNames, DanishMaleNames, DanishSurnames),
            new Name(NameCategoryType.Dragonborn, DragonbornFemaleNames, DragonbornMaleNames, DragonbornSurnames),
            new Name(NameCategoryType.Dutch, DutchFemaleNames, DutchMaleNames, DutchSurnames),
            new Name(NameCategoryType.Dwarf, DwarfFemaleNames, DwarfMaleNames, DwarfSurnames),
            new Name(NameCategoryType.Egyptian, EgyptianFemaleNames, EgyptianMaleNames),
            new Name(NameCategoryType.Elf, ElfFemaleNames, ElfMaleNames, ElfSurnames),
            new Name(NameCategoryType.English, EnglishFemaleNames, EnglishMaleNames, EnglishSurnames),
            new Name(NameCategoryType.Finnish, FinnishFemaleNames, FinnishMaleNames, FinnishSurnames),
            new Name(NameCategoryType.French, FrenchFemaleNames, FrenchMaleNames, FrenchSurnames),
            new Name(NameCategoryType.German, GermanFemaleNames, GermanMaleNames, GermanSurnames),
            new Name(NameCategoryType.Gnome, GnomeFemaleNames, GnomeMaleNames, GnomeSurnames),
            new Name(NameCategoryType.Greek, GreekFemaleNames, GreekMaleNames),
            new Name(NameCategoryType.Halfling, HalflingFemaleNames, HalflingMaleNames, HalflingSurnames),
            new Name(NameCategoryType.HalfOrc, HalfOrcFemaleNames, HalfOrcMaleNames),
            new Name(NameCategoryType.Icelandic, IcelandicFemaleNames, IcelandicMaleNames),
            new Name(NameCategoryType.Indian, IndianFemaleNames, IndianMaleNames, IndianSurnames),
            new Name(NameCategoryType.Irish, IrishFemaleNames, IrishMaleNames, IrishSurnames),
            new Name(NameCategoryType.Italian, ItailianFemaleNames, ItailianMaleNames, ItailianSurnames),
            new Name(NameCategoryType.Japanese, JapaneseFemaleNames, JapaneseMaleNames, JapaneseSurnames),
            new Name(NameCategoryType.Korean, KoreanFemaleNames, KoreanMaleNames),
            new Name(NameCategoryType.Mesoamerican, MesoamericanFemaleNames, MesoamericanMaleNames),
            new Name(NameCategoryType.NigerCongo, NigerCongoFemaleNames, NigerCongoMaleNames),
            new Name(NameCategoryType.Polynesian, PolynesianFemaleNames, PolynesianMaleNames),
            new Name(NameCategoryType.Portuguese, PortugueseFemaleNames, PortugueseMaleNames, PortugueseSurnames),
            new Name(NameCategoryType.Roman, RomanFemaleNames, RomanMaleNames),
            new Name(NameCategoryType.Scottish, ScottishFemaleNames, ScottishMaleNames, ScottishSurnames),
            new Name(NameCategoryType.Slavic, SlavicFemaleNames, SlavicMaleNames, SlavicSurnames),
            new Name(NameCategoryType.Spanish, SpanishFemaleNames, SpanishMaleNames, SpanishSurnames),
            new Name(NameCategoryType.Swedish, SwedishFemaleNames, SwedishMaleNames, SwedishSurnames),
            new Name(NameCategoryType.Tiefling, TieflingFemaleNames, TieflingMaleNames),
            new Name(NameCategoryType.Turkish, TurkishFemaleNames, TurkishMaleNames),
            new Name(NameCategoryType.Welsh, WelshFemaleNames, WelshMaleNames),
        };

    }
}
