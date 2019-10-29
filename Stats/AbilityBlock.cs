using System.Collections.Generic;
using System.Linq;

namespace DMData.Stats
{
    public sealed class AbilityBlock
    {
        private List<AbilityAdjustment> adjustmentList = new List<AbilityAdjustment>();
        public IReadOnlyList<AbilityAdjustment> AdjustmentList => this.adjustmentList;

        private List<AbilityCategoryType> savingThrowProficiencies = new List<AbilityCategoryType>();
        public IReadOnlyList<AbilityCategoryType> SavingThrowProficiencies => this.savingThrowProficiencies;

        public Ability Strength { get; private set; }
        public Ability Dexterity { get; private set; }
        public Ability Constitution { get; private set; }
        public Ability Intelligence { get; private set; }
        public Ability Wisdom { get; private set; }
        public Ability Charisma { get; private set; }

        public AbilityBlock()
        {
            this.Strength = new Ability(AbilityCategoryType.Strength, "Strength", "STR");
            this.Dexterity = new Ability(AbilityCategoryType.Dexterity, "Dexterity", "DEX");
            this.Constitution = new Ability(AbilityCategoryType.Constitution, "Constitution", "CON");
            this.Intelligence = new Ability(AbilityCategoryType.Intelligence, "Intelligence", "INT");
            this.Wisdom = new Ability(AbilityCategoryType.Wisdom, "Wisdom", "WIS");
            this.Charisma = new Ability(AbilityCategoryType.Charisma, "Charisma", "CHA");
        }

        private Ability GetAbility(AbilityCategoryType category)
        {
            switch (category)
            {
                default:
                    return this.Strength;
                case AbilityCategoryType.Charisma:
                    return this.Charisma;
                case AbilityCategoryType.Constitution:
                    return this.Constitution;
                case AbilityCategoryType.Dexterity:
                    return this.Dexterity;
                case AbilityCategoryType.Intelligence:
                    return this.Intelligence;
                case AbilityCategoryType.Strength:
                    return this.Strength;
                case AbilityCategoryType.Wisdom:
                    return this.Wisdom;
            }
        }

        public int GetAdjustedScore(AbilityCategoryType category)
        {
            var ability = this.GetAbility(category);
            var output = ability.BaseScore;
            if (this.adjustmentList.Any(a => a.Category == category))
            {
                foreach (AbilityAdjustment adjustment in this.adjustmentList.Where(a => a.Category == category))
                {
                    output += adjustment.Modifier;
                }

                return output;
            }
            else { return output; }
        }
        public int GetAdjustedModifier(AbilityCategoryType category)
        {
            return AbilityScore.Get(this.GetAdjustedScore(category));
        }
        public int GetAdjustedSavingThrow(AbilityCategoryType category, LevelType level)
        {
            var output = this.GetAdjustedModifier(category);
            
            if (this.savingThrowProficiencies.Any(a => a == category))
            {
                output += LevelInfo.Get(level).ProficiencyBonus;
            }

            return output;
        }


        public void AddAdjustment(AbilityAdjustment adjustment)
        {
            if (adjustment != null)
            {
                if (this.adjustmentList.Any(a => a != adjustment))
                {
                    var tempScore = this.GetAdjustedScore(adjustment.Category);
                    tempScore += adjustment.Modifier;
                    if (AbilityScore.IsValidScore(tempScore)) { this.adjustmentList.Add(adjustment); }
                }
            }
        }
        public void RemoveAdjustment(string name)
        {
            if ((name != null) && !this.adjustmentList.Any(a => a.Name == name))
            {
                this.adjustmentList.RemoveAll(a => a.Name == name);
            }
        }

        public void AddSavingThrowProficiency(AbilityCategoryType category)
        {
            if (!this.savingThrowProficiencies.Any(a => a == category))
            {
                this.savingThrowProficiencies.Add(category);
            }
        }
        public void RemoveSavingThroeProficiency(AbilityCategoryType category)
        {
            if (this.savingThrowProficiencies.Any(a => a == category))
            {
                this.savingThrowProficiencies.Remove(category);
            }
        }
    }
}
