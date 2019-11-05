namespace DMData.Items.Weapons
{
    public interface IAmmunition : IItem
    {
        AmmunitionType Type { get; }
    }
}
