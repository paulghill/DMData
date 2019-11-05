using System;
using System.Collections.Generic;
using System.Linq;

namespace DMData.Names
{
    public static class NamesManagement
    {
        public static IReadOnlyList<CategoryNames> NameData => DataNames.Names;
        public static IReadOnlyList<NameCategoryType> NameCategories => Enum.GetValues(typeof(NameCategoryType)).Cast<NameCategoryType>().ToList();
        public static IReadOnlyList<NameGenderType> Genders => new List<NameGenderType>() { NameGenderType.Female, NameGenderType.Male };
        
        public static IReadOnlyList<MilitaryBranch> MilitaryData => DataMilitary.GetMilitaryBranchData();
        public static IReadOnlyList<MilitaryBranchType> MilitaryBranches => Enum.GetValues(typeof(MilitaryBranchType))
            .Cast<MilitaryBranchType>().ToList();
        public static IReadOnlyList<MilitaryCategoryType> MilitaryCategories => Enum.GetValues(typeof(MilitaryCategoryType))
            .Cast<MilitaryCategoryType>().ToList();
        
        public static IReadOnlyList<Nobility> NobilityData => DataNobility.GetNobilityList();
        public static IReadOnlyList<NobilityCategoryType> NobilityCategories => Enum.GetValues(typeof(NobilityCategoryType))
            .Cast<NobilityCategoryType>().ToList();
        
        public static IReadOnlyList<TitleGroup> TitleData => DataTitles.GetTitleData();
        public static IReadOnlyList<TitleCategoryType> TitleCategories => Enum.GetValues(typeof(TitleCategoryType))
            .Cast<TitleCategoryType>().ToList();

        public static IReadOnlyList<string> DescriptorData => DataDecriptor.GetDescriptors();

        public static RandomName GetRandomName(NameCategoryType category, NameGenderType gender)
        {
            NameGenderType selectedGender;

            var givenName = "";
            var surname = "";
            var randomGenerator = new Random();
            var categoryData = NamesManagement.NameData.Where(a => a.Category == category).FirstOrDefault();

            if (gender == NameGenderType.Unisex)
            {
                if (randomGenerator.Next(2) == 0) { selectedGender = NameGenderType.Female; }
                else { selectedGender = NameGenderType.Male; }
            }
            else { selectedGender = gender; }

            if (selectedGender == NameGenderType.Female)
            {
                givenName = categoryData.FemaleNames[randomGenerator.Next(categoryData.FemaleNames.Count)];
            }
            else
            {
                givenName = categoryData.MaleNames[randomGenerator.Next(categoryData.MaleNames.Count)];
            }

            if (categoryData.HasSurnames)
            {
                surname = categoryData.Surnames[randomGenerator.Next(categoryData.Surnames.Count)];
            }

            return new RandomName(category, selectedGender, givenName, surname);

        }
        public static RandomName GetRandomName(NameCategoryType category) { return GetRandomName(category, NameGenderType.Unisex); }
        public static RandomName GetRandomName()
        {
            var randomGenerator = new Random();
            var category = NameData[randomGenerator.Next(NameData.Count)].Category;
            return GetRandomName(category, NameGenderType.Unisex);
        }
    }
}
