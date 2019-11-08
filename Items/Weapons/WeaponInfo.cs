using System.Collections.Generic;

namespace DMData.Items.Weapons
{
    public static class WeaponInfo
    {
        public static IReadOnlyList<Weapon> WeaponList => new List<Weapon>()
        {
            WeaponInfo.AntimatterRifle,
            WeaponInfo.Battleaxe,
            WeaponInfo.Blowgun,
            WeaponInfo.Boomerang,
            WeaponInfo.Club,
            WeaponInfo.CrossbowHand,
            WeaponInfo.CrossbowHeavy,
            WeaponInfo.CrossbowLight,
            WeaponInfo.Dagger,
            WeaponInfo.Dart,
            WeaponInfo.DoubleBladedScimitar,
            WeaponInfo.Flail,
            WeaponInfo.Glaive,
            WeaponInfo.GreatAxe,
            WeaponInfo.Greatclub,
            WeaponInfo.Greatsword,
            WeaponInfo.Halberd,
            WeaponInfo.Handaxe,
            WeaponInfo.Javelin,
            WeaponInfo.Lance,
            WeaponInfo.LaserPistol,
            WeaponInfo.LaserRifle,
            WeaponInfo.LightHammer,
            WeaponInfo.Longbow,
            WeaponInfo.Longsword,
            WeaponInfo.Mace,
            WeaponInfo.Maul,
            WeaponInfo.Morningstar,
            WeaponInfo.Musket,
            WeaponInfo.Net,
            WeaponInfo.Pike,
            WeaponInfo.Pistol,
            WeaponInfo.PistolAutomatic,
            WeaponInfo.Quarterstaff,
            WeaponInfo.Rapier,
            WeaponInfo.Revolver,
            WeaponInfo.RifleAutomatic,
            WeaponInfo.RifleHunting,
            WeaponInfo.Scimitar,
            WeaponInfo.Shortbow,
            WeaponInfo.Shortsword,
            WeaponInfo.Shotgun,
            WeaponInfo.Sickle,
            WeaponInfo.Sling,
            WeaponInfo.Spear,
            WeaponInfo.Trident,
            WeaponInfo.WarPick,
            WeaponInfo.Warhammer,
            WeaponInfo.Whip,
            WeaponInfo.Yklwa,
        };

        #region Current Weapons

        public static Weapon AntimatterRifle => new Weapon(new Item("Antimatter Rifle", "", 0, 10),
                    WeaponProficiencyGroupType.Futuristic,
                    WeaponProficiencyType.AntimatterRifle,
                    WeaponCategoryType.Ranged,
                    new Damage(DieType.d8, 6, DamageType.Necrotic))
        {
            IsTwoHanded = true,
            Range = new Range(120, 360),
            RangeProperties = new RangeProperties(Ammunition.Get(AmmunitionType.EnergyCell), 2, false),
        };
        public static Weapon Battleaxe => new Weapon(new Item("Battleaxe", "", 10, 4),
                    WeaponProficiencyGroupType.Martial, WeaponProficiencyType.Battleaxe, WeaponCategoryType.Melee,
                    new Damage(DieType.d8, 1, DamageType.Slashing))
        {
            IsVersatile = true,
            VersatileDamage = new Damage(DieType.d10, 1, DamageType.Slashing),
        };
        public static Weapon Blowgun => new Weapon(new Item("Blowgun", "", 10, 1),
                    WeaponProficiencyGroupType.Martial, WeaponProficiencyType.Blowgun, WeaponCategoryType.Ranged,
                    new Damage(DieType.d1, 1, DamageType.Piercing))
        {
            Range = new Range(25, 100),
            RangeProperties = new RangeProperties(Ammunition.Get(AmmunitionType.BlowgunNeedles)),
        };
        public static Weapon Boomerang => new Weapon(new Item("Boomerang", "", 0, 0),
                    WeaponProficiencyGroupType.Simple, WeaponProficiencyType.Boomerang, WeaponCategoryType.Ranged,
                    new Damage(DieType.d4, 1, DamageType.Bludgeoning))
        {
            Range = new Range(60, 120),
        };
        public static Weapon Club => new Weapon(new Item("Club", "", .1, 2),
                    WeaponProficiencyGroupType.Simple, WeaponProficiencyType.Club, WeaponCategoryType.Melee,
                    new Damage(DieType.d4, 1, DamageType.Bludgeoning))
        {
            IsLight = true,
        };
        public static Weapon CrossbowHand => new Weapon(new Item("Crossbow, Hand", "", 75, 3),
                    WeaponProficiencyGroupType.Martial, WeaponProficiencyType.CrossbowHand, WeaponCategoryType.Ranged,
                    new Damage(DieType.d6, 1, DamageType.Piercing))
        {
            Range = new Range(30, 120),
            RangeProperties = new RangeProperties(Ammunition.Get(AmmunitionType.CrossbowBolts), true),
            IsLight = true,
        };
        public static Weapon CrossbowHeavy => new Weapon(new Item("Crossbow, Heavy", "", 50, 18),
                    WeaponProficiencyGroupType.Martial, WeaponProficiencyType.CrossbowHeavy, WeaponCategoryType.Ranged,
                    new Damage(DieType.d10, 1, DamageType.Piercing))
        {
            Range = new Range(100, 400),
            RangeProperties = new RangeProperties(Ammunition.Get(AmmunitionType.CrossbowBolts), true),
            IsHeavy = true,
            IsTwoHanded = true,
        };
        public static Weapon CrossbowLight => new Weapon(new Item("Crossbow, Light", "", 25, 5),
                    WeaponProficiencyGroupType.Simple, WeaponProficiencyType.CrossbowLight, WeaponCategoryType.Ranged,
                    new Damage(DieType.d8, 1, DamageType.Piercing))
        {
            Range = new Range(80, 320),
            RangeProperties = new RangeProperties(Ammunition.Get(AmmunitionType.CrossbowBolts), true),
            IsTwoHanded = true,
        };
        public static Weapon Dagger => new Weapon(new Item("Dagger", "", 2, 1),
                    WeaponProficiencyGroupType.Simple, WeaponProficiencyType.Dagger, WeaponCategoryType.Melee,
                    new Damage(DieType.d4, 1, DamageType.Piercing))
        {
            IsFinesse = true,
            IsLight = true,
            IsThrown = true,
            Range = new Range(20, 60),
        };
        public static Weapon Dart => new Weapon(new Item("Dart", "", .05, .25),
                    WeaponProficiencyGroupType.Simple, WeaponProficiencyType.Dart, WeaponCategoryType.Ranged,
                    new Damage(DieType.d4, 1, DamageType.Piercing))
        {
            IsFinesse = true,
            IsThrown = true,
            Range = new Range(20, 60),
        };
        public static Weapon DoubleBladedScimitar => new Weapon(new Item("Double-Bladed Scimitar", "The " +
                    "double scimitar is the signature Weapon of Valenar elves. " +
                    "A haft of fine wood supports a long blade on either end. Forged with techniques " +
                    "honed over tens of thousands of years, these blades are strong, sharp, and " +
                    "remarkably light. Each scimitar is a masterpiece, and as a result the double " +
                    "scimitar is an expensive weapon, but few people ever have an opportunity to purchase " +
                    "one. If you’re an elf, your blade could have a long and storied history. If you’re not " +
                    "an elf, you might have stolen the Weapon from a fallen foe or received it from a dying " +
                    "Valenar ally. If you work with your DM to create the story behind your double scimitar, " +
                    "you can start with the Weapon at 1st level in place of a martial Weapon normally granted " +
                    "by your class. However, it can be dangerous for a non-elf to carry a double scimitar. " +
                    "Valenar may demand its return or challenge you to prove that you’re worthy to wield it.", 100, 6),
                    WeaponProficiencyGroupType.Martial, WeaponProficiencyType.DoubleBladedScimitar, WeaponCategoryType.Melee,
                    new Damage(DieType.d4, 2, DamageType.Slashing))
        {
            SpecialNote = "When you take the attack action and make a two-handed attack with a " +
                    "double-bladed scimitar, you can use a bonus action to make a melee attack with the" +
                    " blade at the opposite end of the weapon. This attack uses the same ability modifier " +
                    "as the primary attack. The weapon’s damage die for this attack is a d4, and it deals " +
                    "slashing damage.",
            IsTwoHanded = true,
        };
        public static Weapon Flail => new Weapon(new Item("Flail", "", 10, 2),
                    WeaponProficiencyGroupType.Martial, WeaponProficiencyType.Flail, WeaponCategoryType.Melee,
                    new Damage(DieType.d8, 1, DamageType.Bludgeoning));
        public static Weapon Glaive => new Weapon(new Item("Glaive", "", 20, 6),
                    WeaponProficiencyGroupType.Martial, WeaponProficiencyType.Glaive, WeaponCategoryType.Melee,
                    new Damage(DieType.d10, 1, DamageType.Slashing))
        {
            IsHeavy = true,
            HasReach = true,
            IsTwoHanded = true,
        };
        public static Weapon GreatAxe => new Weapon(new Item("Greataxe", "", 30, 7),
                    WeaponProficiencyGroupType.Martial, WeaponProficiencyType.GreatAxe, WeaponCategoryType.Melee,
                    new Damage(DieType.d12, 1, DamageType.Slashing))
        {
            IsHeavy = true,
            IsTwoHanded = true,
        };
        public static Weapon Greatclub => new Weapon(new Item("Greatclub", "", .2, 10),
                    WeaponProficiencyGroupType.Simple, WeaponProficiencyType.Greatclub, WeaponCategoryType.Melee,
                    new Damage(DieType.d8, 1, DamageType.Bludgeoning))
        {
            IsTwoHanded = true,
        };
        public static Weapon Greatsword => new Weapon(new Item("Greatsword", "", 50, 6),
                    WeaponProficiencyGroupType.Martial, WeaponProficiencyType.Greatsword, WeaponCategoryType.Melee,
                    new Damage(DieType.d6, 2, DamageType.Slashing))
        {
            IsHeavy = true,
            IsTwoHanded = true,
        };
        public static Weapon Halberd => new Weapon(new Item("Halberd", "", 20, 6),
                    WeaponProficiencyGroupType.Martial, WeaponProficiencyType.Halberd, WeaponCategoryType.Melee,
                    new Damage(DieType.d10, 1, DamageType.Slashing))
        {
            IsHeavy = true,
            HasReach = true,
            IsTwoHanded = true,
        };
        public static Weapon Handaxe => new Weapon(new Item("Handaxe", "", 5, 2),
                    WeaponProficiencyGroupType.Simple, WeaponProficiencyType.Handaxe, WeaponCategoryType.Melee,
                    new Damage(DieType.d6, 1, DamageType.Slashing))
        {
            IsLight = true,
            IsThrown = true,
            Range = new Range(20, 60),
        };
        public static Weapon Javelin => new Weapon(new Item("Javelin", "", .5, 2),
                    WeaponProficiencyGroupType.Simple, WeaponProficiencyType.Javelin, WeaponCategoryType.Melee,
                    new Damage(DieType.d6, 1, DamageType.Piercing))
        {
            IsThrown = true,
            Range = new Range(30, 120),
        };
        public static Weapon Lance => new Weapon(new Item("Lance", "", 10, 6),
                    WeaponProficiencyGroupType.Martial, WeaponProficiencyType.Lance, WeaponCategoryType.Melee,
                    new Damage(DieType.d12, 1, DamageType.Piercing))
        {
            SpecialNote = "You have disadvantage when you use a lance to attack a " +
                    "tar within 5 feet of you. Also, a lance requires two hands to wield " +
                    "when you aren't mounted.",
            HasReach = true,
        };
        public static Weapon LaserPistol => new Weapon(new Item("Laser Pistol", "", 0, 2),
                    WeaponProficiencyGroupType.Futuristic, WeaponProficiencyType.LaserPistol, WeaponCategoryType.Ranged,
                    new Damage(DieType.d6, 3, DamageType.Radiant))
        {
            Range = new Range(40, 120),
            RangeProperties = new RangeProperties(Ammunition.Get(AmmunitionType.EnergyCell), 50, false),
        };
        public static Weapon LaserRifle => new Weapon(new Item("Laser Rifle", "", 0, 7),
                    WeaponProficiencyGroupType.Futuristic, WeaponProficiencyType.LaserRifle, WeaponCategoryType.Ranged,
                    new Damage(DieType.d8, 3, DamageType.Radiant))
        {
            IsTwoHanded = true,
            Range = new Range(100, 300),
            RangeProperties = new RangeProperties(Ammunition.Get(AmmunitionType.EnergyCell), 30, false),
        };
        public static Weapon LightHammer => new Weapon(new Item("Light Hammer", "", 2, 2),
                    WeaponProficiencyGroupType.Simple, WeaponProficiencyType.LightHammer, WeaponCategoryType.Melee,
                    new Damage(DieType.d4, 1, DamageType.Bludgeoning))
        {
            IsLight = true,
            IsThrown = true,
            Range = new Range(20, 60),
        };
        public static Weapon Longbow => new Weapon(new Item("Longbow", "", 50, 2),
                    WeaponProficiencyGroupType.Martial, WeaponProficiencyType.Longbow, WeaponCategoryType.Ranged,
                    new Damage(DieType.d8, 1, DamageType.Piercing))
        {
            IsHeavy = true,
            Range = new Range(150, 600),
            IsTwoHanded = true,
            RangeProperties = new RangeProperties(Ammunition.Get(AmmunitionType.Arrows)),
        };
        public static Weapon Longsword => new Weapon(new Item("Longsword", "", 15, 3),
                    WeaponProficiencyGroupType.Martial, WeaponProficiencyType.Longsword, WeaponCategoryType.Melee,
                    new Damage(DieType.d8, 1, DamageType.Slashing))
        {
            IsVersatile = true,
            VersatileDamage = new Damage(DieType.d10, 1, DamageType.Slashing)
        };
        public static Weapon Mace => new Weapon(new Item("Mace", "", 5, 4),
                    WeaponProficiencyGroupType.Simple, WeaponProficiencyType.Mace, WeaponCategoryType.Melee,
                    new Damage(DieType.d6, 1, DamageType.Bludgeoning));
        public static Weapon Maul => new Weapon(new Item("Maul", "", 10, 10),
                    WeaponProficiencyGroupType.Martial, WeaponProficiencyType.Maul, WeaponCategoryType.Melee,
                    new Damage(DieType.d6, 2, DamageType.Bludgeoning))
        {
            IsHeavy = true,
            IsTwoHanded = true,
        };
        public static Weapon Morningstar => new Weapon(new Item("Morningstar", "", 15, 4),
                    WeaponProficiencyGroupType.Martial, WeaponProficiencyType.Morningstar, WeaponCategoryType.Melee,
                    new Damage(DieType.d8, 1, DamageType.Bludgeoning));
        public static Weapon Musket => new Weapon(new Item("Musket", "", 500, 10),
                    WeaponProficiencyGroupType.Blackpowder, WeaponProficiencyType.Musket, WeaponCategoryType.Ranged,
                    new Damage(DieType.d12, 1, DamageType.Piercing))
        {
            Range = new Range(40, 120),
            RangeProperties = new RangeProperties(Ammunition.Get(AmmunitionType.Blackpowder), true),
            IsTwoHanded = true,
        };
        public static Weapon Net => new Weapon(new Item("Net", "", 1, 3),
                    WeaponProficiencyGroupType.Martial, WeaponProficiencyType.Net, WeaponCategoryType.Ranged,
                    new Damage(DieType.d0, 1, DamageType.Bludgeoning))
        {
            SpecialNote = "A Large or smaller creature hit by a net is restrained until " +
                    "it is freed. A net has no effect on creatures that are formless, or " +
                    "creatures that are Huge or larger. A creature can use its action to make a " +
                    "DC 10 Strength check, freeing itself or another creature within its reach on a " +
                    "success. Dealing 5 slashing damage to the net (AC 10) also frees the creature " +
                    "without harming it, ending the effect and destroying the net." +
                    "When you use an action, bonus action, or reaction to attack with a net, you " +
                    "can make only one attack regardless of the number of attacks you can normally make.",
            IsThrown = true,
            Range = new Range(5, 15),
        };
        public static Weapon Pike => new Weapon(new Item("Pike", "", 5, 18),
                    WeaponProficiencyGroupType.Martial, WeaponProficiencyType.Pike, WeaponCategoryType.Melee,
                    new Damage(DieType.d10, 1, DamageType.Piercing));
        public static Weapon Pistol => new Weapon(new Item("Pistol", "", 250, 3),
                    WeaponProficiencyGroupType.Blackpowder, WeaponProficiencyType.Pistol, WeaponCategoryType.Ranged,
                    new Damage(DieType.d10, 1, DamageType.Piercing))
        {
            Range = new Range(30, 90),
            RangeProperties = new RangeProperties(Ammunition.Get(AmmunitionType.Blackpowder), true),
        };
        public static Weapon PistolAutomatic => new Weapon(new Item("Pistol, Automatic", "", 0, 3),
                    WeaponProficiencyGroupType.Firearms, WeaponProficiencyType.PistolAutomatic, WeaponCategoryType.Ranged,
                    new Damage(DieType.d6, 2, DamageType.Piercing))
        {
            Range = new Range(50, 150),
            RangeProperties = new RangeProperties(Ammunition.Get(AmmunitionType.Bullets), 15, true),
        };
        public static Weapon Quarterstaff => new Weapon(new Item("Quarterstaff", "", .2, 4),
                    WeaponProficiencyGroupType.Simple, WeaponProficiencyType.Quarterstaff, WeaponCategoryType.Melee,
                    new Damage(DieType.d6, 1, DamageType.Bludgeoning))
        {
            IsVersatile = true,
            VersatileDamage = new Damage(DieType.d8, 1, DamageType.Bludgeoning),
        };
        public static Weapon Rapier => new Weapon(new Item("Rapier", "", 25, 2),
                    WeaponProficiencyGroupType.Martial, WeaponProficiencyType.Rapier, WeaponCategoryType.Melee,
                    new Damage(DieType.d8, 1, DamageType.Piercing))
        {
            IsFinesse = true,
        };
        public static Weapon Revolver => new Weapon(new Item("Revolver", "", 0, 3),
                    WeaponProficiencyGroupType.Firearms, WeaponProficiencyType.Revolver, WeaponCategoryType.Ranged,
                    new Damage(DieType.d8, 2, DamageType.Piercing))
        {
            Range = new Range(40, 120),
            RangeProperties = new RangeProperties(Ammunition.Get(AmmunitionType.Bullets), 6, false),
        };
        public static Weapon RifleAutomatic => new Weapon(new Item("Rifle, Automatic", "", 0, 8),
                    WeaponProficiencyGroupType.Firearms, WeaponProficiencyType.RifleAutomatic, WeaponCategoryType.Ranged,
                    new Damage(DieType.d8, 2, DamageType.Piercing))
        {
            IsTwoHanded = true,
            Range = new Range(80, 240),
            RangeProperties = new RangeProperties(Ammunition.Get(AmmunitionType.Bullets), 30, true),
        };
        public static Weapon RifleHunting => new Weapon(new Item("Rifle, Hunting", "", 0, 8),
                    WeaponProficiencyGroupType.Firearms, WeaponProficiencyType.RifleHunting, WeaponCategoryType.Ranged,
                    new Damage(DieType.d10, 2, DamageType.Piercing))
        {
            IsTwoHanded = true,
            Range = new Range(80, 240),
            RangeProperties = new RangeProperties(Ammunition.Get(AmmunitionType.Bullets), 5, false),
        };
        public static Weapon Scimitar => new Weapon(new Item("Scimitar", "", 25, 3),
                    WeaponProficiencyGroupType.Martial, WeaponProficiencyType.Scimitar, WeaponCategoryType.Melee,
                    new Damage(DieType.d8, 1, DamageType.Slashing))
        {
            IsFinesse = true,
            IsLight = true,
        };
        public static Weapon Shortbow => new Weapon(new Item("Shortbow", "", 25, 2),
                    WeaponProficiencyGroupType.Simple, WeaponProficiencyType.Shortbow, WeaponCategoryType.Ranged,
                    new Damage(DieType.d6, 1, DamageType.Piercing))
        {
            IsTwoHanded = true,
            Range = new Range(80, 320),
            RangeProperties = new RangeProperties(Ammunition.Get(AmmunitionType.Arrows)),
        };
        public static Weapon Shortsword => new Weapon(new Item("Shortsword", "", 10, 2),
                    WeaponProficiencyGroupType.Martial, WeaponProficiencyType.Shortsword, WeaponCategoryType.Melee,
                    new Damage(DieType.d6, 1, DamageType.Piercing))
        {
            IsFinesse = true,
            IsLight = true,
        };
        public static Weapon Shotgun => new Weapon(new Item("Shotgun", "", 0, 7),
                    WeaponProficiencyGroupType.Firearms, WeaponProficiencyType.Shotgun, WeaponCategoryType.Ranged,
                    new Damage(DieType.d8, 2, DamageType.Piercing))
        {
            IsTwoHanded = true,
            Range = new Range(30, 90),
            RangeProperties = new RangeProperties(Ammunition.Get(AmmunitionType.Bullets), 2, false),
        };
        public static Weapon Sickle => new Weapon(new Item("Sickle", "", 1, 2),
                    WeaponProficiencyGroupType.Simple, WeaponProficiencyType.Sickle, WeaponCategoryType.Melee,
                    new Damage(DieType.d4, 1, DamageType.Slashing))
        {
            IsLight = true,
        };
        public static Weapon Sling => new Weapon(new Item("Sling", "", .1, 0),
                    WeaponProficiencyGroupType.Simple, WeaponProficiencyType.Sling, WeaponCategoryType.Ranged,
                    new Damage(DieType.d4, 1, DamageType.Bludgeoning))
        {
            Range = new Range(30, 120),
            RangeProperties = new RangeProperties(Ammunition.Get(AmmunitionType.SlingBullets)),
        };
        public static Weapon Spear => new Weapon(new Item("Spear", "", 1, 3),
                    WeaponProficiencyGroupType.Simple, WeaponProficiencyType.Spear, WeaponCategoryType.Melee,
                    new Damage(DieType.d6, 1, DamageType.Piercing))
        {
            IsVersatile = true,
            VersatileDamage = new Damage(DieType.d8, 1, DamageType.Piercing),
            IsThrown = true,
            Range = new Range(20, 60),
        };
        public static Weapon Trident => new Weapon(new Item("Trident", "", 5, 4),
                    WeaponProficiencyGroupType.Martial, WeaponProficiencyType.Trident, WeaponCategoryType.Melee,
                    new Damage(DieType.d6, 1, DamageType.Piercing))
        {
            IsVersatile = true,
            VersatileDamage = new Damage(DieType.d8, 1, DamageType.Piercing),
            IsThrown = true,
            Range = new Range(20, 60),
        };
        public static Weapon WarPick => new Weapon(new Item("War Pick", "", 5, 2),
                    WeaponProficiencyGroupType.Martial, WeaponProficiencyType.Warhammer, WeaponCategoryType.Melee,
                    new Damage(DieType.d8, 1, DamageType.Piercing));
        public static Weapon Warhammer => new Weapon(new Item("Warhammer", "", 15, 2),
                    WeaponProficiencyGroupType.Martial, WeaponProficiencyType.WarPick, WeaponCategoryType.Melee,
                    new Damage(DieType.d8, 1, DamageType.Bludgeoning))
        {
            IsVersatile = true,
            VersatileDamage = new Damage(DieType.d10, 1, DamageType.Bludgeoning),
        };
        public static Weapon Whip => new Weapon(new Item("Whip", "", 2, 3),
                    WeaponProficiencyGroupType.Martial, WeaponProficiencyType.Whip, WeaponCategoryType.Melee,
                    new Damage(DieType.d4, 1, DamageType.Slashing))
        {
            IsFinesse = true,
            HasReach = true,
        };
        public static Weapon Yklwa => new Weapon(new Item("Yklwa", "A yklwa (pronounced YICK-ul-wah) is a simple melee Weapon " +
                    "that is the traditional Weapon of Chultan warriors. A yklwa consists " +
                    "of a 3-foot wooden shaft with a steel or stone blade up to 18 inches " +
                    "long. It costs 1 gp, and it deals 1d8 piercing damage on a hit. " +
                    "Although it has the thrown Weapon property, the yklwa is not well " +
                    "balanced for throwing (range 10/30 ft.).", 1, 2),
                    WeaponProficiencyGroupType.Simple, WeaponProficiencyType.Yklwa, WeaponCategoryType.Melee,
                    new Damage(DieType.d8, 1, DamageType.Piercing))
        {
            IsThrown = true,
            Range = new Range(10, 30),
        };

        #endregion
    }
}
