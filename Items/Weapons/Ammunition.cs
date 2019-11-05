using System.Collections.Generic;
using System.Linq;

namespace DMData.Items.Weapons
{
    public sealed class Ammunition : Item, IAmmunition
    {
        static readonly IReadOnlyList<Ammunition> AmmunitionList = new List<Ammunition>()
        {
            new Ammunition(new Item( "Black Powder/Bullet (10)", "", 3, 2), AmmunitionType.Blackpowder),
            new Ammunition(new Item("Bullets (10)", "", 0, 1), AmmunitionType.Bullets),
            new Ammunition(new Item("Energy Cell", "", 0, .3125), AmmunitionType.EnergyCell),
            new Ammunition(new Item("Arrows (20)","", 1, 1), AmmunitionType.Arrows),
            new Ammunition(new Item("Blowgun Needles (50)","", 1, 1), AmmunitionType.BlowgunNeedles),
            new Ammunition(new Item("Crossbow Bolts (20)","", 1, 1.5), AmmunitionType.CrossbowBolts),
            new Ammunition(new Item("Sling Bullets (20)","", .04, 1.5), AmmunitionType.SlingBullets),
        };

        public AmmunitionType Type { get; private set; }

        public Ammunition(Item item, AmmunitionType type) : base(item) { this.Type = type; }

        public static Ammunition Get(AmmunitionType type)
        {
            return AmmunitionList.Where(a => a.Type == type).FirstOrDefault();
        }
    }
}
