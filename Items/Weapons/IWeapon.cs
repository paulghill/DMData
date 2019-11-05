namespace DMData.Items.Weapons
{
    public interface IWeapon : IItem
    {
        ProficiencyGroupType ProficiencyGroup { get; }
        CategoryType Category { get; }
        Damage Damage { get; }

        bool IsVersatile { get; set; }
        Damage VersatileDamage { get; set; }

        bool IsThrown { get; set; }
        bool IsFinesse { get; set; }
        bool IsLight { get; set; }
        bool IsHeavy { get; set; }
        bool IsTwoHanded { get; set; }
        bool HasReach { get; set; }

        bool HasSpecialNote { get; }
        string SpecialNote { get; set; }

        bool HasRange { get; }
        Range Range { get; set; }

        bool HasRangeProperties { get; }
        RangeProperties RangeProperties { get; set; }
    }
}
