using System.Collections.Generic;

namespace DMData.Items.Weapons
{
    public sealed class Weapon : Item, IWeapon
    {
        public WeaponProficiencyGroupType ProficiencyGroup { get; private set; }
        public WeaponCategoryType Category { get; private set; }
        public Damage Damage { get; private set; }
        public WeaponProficiencyType Proficiency { get; private set; }

        public bool IsVersatile { get; set; }
        public Damage VersatileDamage { get; set; }

        public bool IsThrown { get; set; }
        public bool IsFinesse { get; set; }
        public bool IsLight { get; set; }
        public bool IsHeavy { get; set; }
        public bool IsTwoHanded { get; set; }
        public bool HasReach { get; set; }

        public bool HasSpecialNote { get; private set; }
        public string SpecialNote 
        {
            get { return this.SpecialNote; } 
            set 
            {
                if ((value == null) || value.Length == 0)
                {
                    this.HasSpecialNote = false;
                    this.SpecialNote = "";
                }
                else
                {
                    this.HasSpecialNote = true;
                    this.SpecialNote = value;
                }
            } 
        }

        public bool HasRange { get; private set; }
        public Range Range
        {
            get { return this.Range; }
            set
            {
                if (value == null) { this.HasRange = false; }
                else
                {
                    this.HasRange = true;
                    this.Range = value;
                }
            }
        }

        public bool HasRangeProperties { get; private set; }
        public RangeProperties RangeProperties
        {
            get { return this.RangeProperties; }
            set
            {
                if (value == null) { this.HasRangeProperties = false; }
                else
                {
                    this.HasRangeProperties = true;
                    this.RangeProperties = value;
                }
            }
        }

        public Weapon(Item item, WeaponProficiencyGroupType type, WeaponProficiencyType proficiency, WeaponCategoryType category, Damage damage) : base(item)
        {
            this.ProficiencyGroup = type;
            this.Proficiency = proficiency;
            this.Category = category;
            this.Damage = damage;
        }
    }
}
