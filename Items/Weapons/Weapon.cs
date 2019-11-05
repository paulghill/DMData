using System.Collections.Generic;

namespace DMData.Items.Weapons
{
    public sealed class Weapon : Item, IWeapon
    {
        public static IReadOnlyList<Weapon> WeaponList => new List<Weapon>()
        {
            Weapon.AntimatterRifle(),
            Weapon.Battleaxe(),
            Weapon.Blowgun(),
            Weapon.Boomerang(),
            Weapon.Club(),
            Weapon.CrossbowHand(),
            Weapon.CrossbowHeavy(),
            Weapon.CrossbowLight(),
            Weapon.Dagger(),
            Weapon.Dart(),
            Weapon.DoubleBladedScimitar(),
            Weapon.Flail(),
            Weapon.Glaive(),
            Weapon.GreatAxe(),
            Weapon.Greatclub(),
            Weapon.Greatsword(),
            Weapon.Halberd(),
            Weapon.Handaxe(),
            Weapon.Javelin(),
            Weapon.Lance(),
            Weapon.LaserPistol(),
            Weapon.LaserRifle(),
            Weapon.LightHammer(),
            Weapon.Longbow(),
            Weapon.Longsword(),
            Weapon.Mace(),
            Weapon.Maul(),
            Weapon.Morningstar(),
            Weapon.Musket(),
            Weapon.Net(),
        };

        #region Current Weapons

        private static Weapon AntimatterRifle()
        {
            return new Weapon(new Item("Antimatter Rifle", "", 0, 10),
                ProficiencyGroupType.Futuristic, CategoryType.Ranged,
                new Damage(DieType.d8, 6, DamageCategoryType.Necrotic))
            {
                IsTwoHanded = true,
                Range = new Range(120, 360),
                RangeProperties = new RangeProperties(Ammunition.Get(AmmunitionType.EnergyCell), 2, false),
            };
        }
        private static Weapon Battleaxe()
        {
            return new Weapon(new Item("Battleaxe", "", 10, 4),
                ProficiencyGroupType.Martial, CategoryType.Melee,
                new Damage(DieType.d8, 1, DamageCategoryType.Slashing))
            {
                IsVersatile = true,
                VersatileDamage = new Damage(DieType.d10, 1, DamageCategoryType.Slashing),
            };
        }
        private static Weapon Blowgun()
        {
            return new Weapon(new Item("Blowgun", "", 10, 1),
                ProficiencyGroupType.Martial, CategoryType.Ranged,
                new Damage(DieType.d1, 1, DamageCategoryType.Piercing))
            {
                Range = new Range(25, 100),
                RangeProperties = new RangeProperties(Ammunition.Get(AmmunitionType.BlowgunNeedles)),
            };
        }
        private static Weapon Boomerang()
        {
            return new Weapon(new Item("Boomerang", "", 0, 0),
                ProficiencyGroupType.Simple, CategoryType.Ranged,
                new Damage(DieType.d4, 1, DamageCategoryType.Bludgeoning))
            {
                Range = new Range(60, 120),
            };
        }
        private static Weapon Club()
        {
            return new Weapon(new Item("Club", "", .1, 2),
                ProficiencyGroupType.Simple, CategoryType.Melee,
                new Damage(DieType.d4, 1, DamageCategoryType.Bludgeoning))
            {
                IsLight = true,
            };
        }
        private static Weapon CrossbowHand()
        {
            return new Weapon(new Item("Crossbow, Hand", "", 75, 3),
                ProficiencyGroupType.Martial, CategoryType.Ranged,
                new Damage(DieType.d6, 1, DamageCategoryType.Piercing))
            {
                Range = new Range(30, 120),
                RangeProperties = new RangeProperties(Ammunition.Get(AmmunitionType.CrossbowBolts), true),
                IsLight = true,
            };
        }
        private static Weapon CrossbowHeavy()
        {
            return new Weapon(new Item("Crossbow, Heavy", "", 50, 18),
                ProficiencyGroupType.Martial, CategoryType.Ranged,
                new Damage(DieType.d10, 1, DamageCategoryType.Piercing))
            {
                Range = new Range(100, 400),
                RangeProperties = new RangeProperties(Ammunition.Get(AmmunitionType.CrossbowBolts), true),
                IsHeavy = true,
                IsTwoHanded = true,
            };
        }
        private static Weapon CrossbowLight()
        {
            return new Weapon(new Item("Crossbow, Light", "", 25, 5),
                ProficiencyGroupType.Simple, CategoryType.Ranged,
                new Damage(DieType.d8, 1, DamageCategoryType.Piercing))
            {
                Range = new Range(80, 320),
                RangeProperties = new RangeProperties(Ammunition.Get(AmmunitionType.CrossbowBolts), true),
                IsTwoHanded = true,
            };
        }
        private static Weapon Dagger()
        {
            return new Weapon(new Item("Dagger", "", 2, 1),
                ProficiencyGroupType.Simple, CategoryType.Melee,
                new Damage(DieType.d4, 1, DamageCategoryType.Piercing))
            {
                IsFinesse = true,
                IsLight = true,
                IsThrown = true,
                Range = new Range(20, 60),
            };
        }
        private static Weapon Dart()
        {
            return new Weapon(new Item("Dart", "", .05, .25),
                ProficiencyGroupType.Simple, CategoryType.Ranged,
                new Damage(DieType.d4, 1, DamageCategoryType.Piercing))
            {
                IsFinesse = true,
                IsThrown = true,
                Range = new Range(20, 60),
            };
        }
        private static Weapon DoubleBladedScimitar()
        {
            var decription = "The double scimitar is the signature weapon of Valenar elves. " +
                "A haft of fine wood supports a long blade on either end. Forged with techniques " +
                "honed over tens of thousands of years, these blades are strong, sharp, and " +
                "remarkably light. Each scimitar is a masterpiece, and as a result the double " +
                "scimitar is an expensive weapon, but few people ever have an opportunity to purchase " +
                "one. If you’re an elf, your blade could have a long and storied history. If you’re not " +
                "an elf, you might have stolen the weapon from a fallen foe or received it from a dying " +
                "Valenar ally. If you work with your DM to create the story behind your double scimitar, " +
                "you can start with the weapon at 1st level in place of a martial weapon normally granted " +
                "by your class. However, it can be dangerous for a non-elf to carry a double scimitar. " +
                "Valenar may demand its return or challenge you to prove that you’re worthy to wield it.";
            var note = "When you take the attack action and make a two-handed attack with a " +
                "double-bladed scimitar, you can use a bonus action to make a melee attack with the" +
                " blade at the opposite end of the weapon. This attack uses the same ability modifier " +
                "as the primary attack. The weapon’s damage die for this attack is a d4, and it deals " +
                "slashing damage.";
            return new Weapon(new Item("Double-Bladed Scimitar", decription, 100, 6),
                ProficiencyGroupType.Martial, CategoryType.Melee,
                new Damage(DieType.d4, 2, DamageCategoryType.Slashing))
            {
                SpecialNote = note,
                IsTwoHanded = true,
            };
        }
        private static Weapon Flail()
        {
            return new Weapon(new Item("Flail", "", 10, 2),
                ProficiencyGroupType.Martial, CategoryType.Melee,
                new Damage(DieType.d8, 1, DamageCategoryType.Bludgeoning));
        }
        private static Weapon Glaive()
        {
            return new Weapon(new Item("Glaive", "", 20, 6),
                ProficiencyGroupType.Martial, CategoryType.Melee,
                new Damage(DieType.d10, 1, DamageCategoryType.Slashing))
            {
                IsHeavy = true,
                HasReach = true,
                IsTwoHanded = true,
            };
        }
        private static Weapon GreatAxe()
        {
            return new Weapon(new Item("Greataxe", "", 30, 7),
                ProficiencyGroupType.Martial, CategoryType.Melee,
                new Damage(DieType.d12, 1, DamageCategoryType.Slashing))
            {
                IsHeavy = true,
                IsTwoHanded = true,
            };
        }
        private static Weapon Greatclub()
        {
            return new Weapon(new Item("Greatclub", "", .2, 10),
                ProficiencyGroupType.Simple, CategoryType.Melee,
                new Damage(DieType.d8, 1, DamageCategoryType.Bludgeoning))
            {
                IsTwoHanded = true,
            };
        }
        private static Weapon Greatsword()
        {
            return new Weapon(new Item("Greatsword", "", 50, 6),
                ProficiencyGroupType.Martial, CategoryType.Melee,
                new Damage(DieType.d6, 2, DamageCategoryType.Slashing))
            {
                IsHeavy = true,
                IsTwoHanded = true,
            };
        }
        private static Weapon Halberd()
        {
            return new Weapon(new Item("Halberd", "", 20, 6),
                ProficiencyGroupType.Martial, CategoryType.Melee,
                new Damage(DieType.d10, 1, DamageCategoryType.Slashing))
            {
                IsHeavy = true,
                HasReach = true,
                IsTwoHanded = true,
            };
        }
        private static Weapon Handaxe()
        {
            return new Weapon(new Item("Handaxe", "", 5, 2),
                ProficiencyGroupType.Simple, CategoryType.Melee,
                new Damage(DieType.d6, 1, DamageCategoryType.Slashing))
            {
                IsLight = true,
                IsThrown = true,
                Range = new Range(20, 60),
            };
        }
        private static Weapon Javelin()
        {
            return new Weapon(new Item("Javelin", "", .5, 2),
                ProficiencyGroupType.Simple, CategoryType.Melee,
                new Damage(DieType.d6, 1, DamageCategoryType.Piercing))
            {
                IsThrown = true,
                Range = new Range(30, 120),
            };
        }
        private static Weapon Lance()
        {
            var note = "You have disadvantage when you use a lance to attack a " +
                "target within 5 feet of you. Also, a lance requires two hands to wield " +
                "when you aren't mounted.";
            return new Weapon(new Item("Lance", "", 10, 6),
                ProficiencyGroupType.Martial, CategoryType.Melee,
                new Damage(DieType.d12, 1, DamageCategoryType.Piercing))
            {
                SpecialNote = note,
                HasReach = true,
            };
        }
        private static Weapon LaserPistol()
        {
            return new Weapon(new Item("Laser Pistol", "", 0, 2),
                ProficiencyGroupType.Futuristic, CategoryType.Ranged,
                new Damage(DieType.d6, 3, DamageCategoryType.Radiant))
            {
                Range = new Range(40, 120),
                RangeProperties = new RangeProperties(Ammunition.Get(AmmunitionType.EnergyCell), 50, false),
            };
        }
        private static Weapon LaserRifle()
        {
            return new Weapon(new Item("Laser Rifle", "", 0, 7),
                ProficiencyGroupType.Futuristic, CategoryType.Ranged,
                new Damage(DieType.d8, 3, DamageCategoryType.Radiant))
            {
                IsTwoHanded = true,
                Range = new Range(100, 300),
                RangeProperties = new RangeProperties(Ammunition.Get(AmmunitionType.EnergyCell), 30, false),
            };
        }
        private static Weapon LightHammer()
        {
            return new Weapon(new Item("Light Hammer", "", 2, 2),
                ProficiencyGroupType.Simple, CategoryType.Melee,
                new Damage(DieType.d4, 1, DamageCategoryType.Bludgeoning))
            {
                IsLight = true,
                IsThrown = true,
                Range = new Range(20, 60),
            };
        }
        private static Weapon Longbow()
        {
            return new Weapon(new Item("Longbow", "", 50, 2),
                ProficiencyGroupType.Martial, CategoryType.Ranged,
                new Damage(DieType.d8, 1, DamageCategoryType.Piercing))
            {
                IsHeavy = true,
                Range = new Range(150, 600),
                IsTwoHanded = true,
                RangeProperties = new RangeProperties(Ammunition.Get(AmmunitionType.Arrows)),
            };
        }
        private static Weapon Longsword()
        {
            return new Weapon(new Item("Longsword", "", 15, 3),
                ProficiencyGroupType.Martial, CategoryType.Melee,
                new Damage(DieType.d8, 1, DamageCategoryType.Slashing))
            {
                IsVersatile = true,
                VersatileDamage = new Damage(DieType.d10,1, DamageCategoryType.Slashing)
            };
        }
        private static Weapon Mace()
        {
            return new Weapon(new Item("Mace", "", 5, 4),
                ProficiencyGroupType.Simple, CategoryType.Melee,
                new Damage(DieType.d6, 1, DamageCategoryType.Bludgeoning));
        }
        private static Weapon Maul()
        {
            return new Weapon(new Item("Maul", "", 10, 10),
                ProficiencyGroupType.Martial, CategoryType.Melee,
                new Damage(DieType.d6, 2, DamageCategoryType.Bludgeoning))
            {
                IsHeavy = true,
                IsTwoHanded = true,
            };
        }
        private static Weapon Morningstar()
        {
            return new Weapon(new Item("Morningstar", "", 15, 4),
                ProficiencyGroupType.Martial, CategoryType.Melee,
                new Damage(DieType.d8, 1, DamageCategoryType.Bludgeoning));
        }
        private static Weapon Musket()
        {
            return new Weapon(new Item("Musket", "", 500, 10),
                ProficiencyGroupType.Blackpowder, CategoryType.Ranged,
                new Damage(DieType.d12, 1, DamageCategoryType.Piercing))
            {
                Range = new Range(40, 120),
                RangeProperties = new RangeProperties(Ammunition.Get(AmmunitionType.Blackpowder), true),
                IsTwoHanded = true,
            };
        }
        private static Weapon Net()
        {
            var note = "A Large or smaller creature hit by a net is restrained until " +
                "it is freed. A net has no effect on creatures that are formless, or " +
                "creatures that are Huge or larger. A creature can use its action to make a " +
                "DC 10 Strength check, freeing itself or another creature within its reach on a " +
                "success. Dealing 5 slashing damage to the net (AC 10) also frees the creature " +
                "without harming it, ending the effect and destroying the net." +
                "When you use an action, bonus action, or reaction to attack with a net, you " +
                "can make only one attack regardless of the number of attacks you can normally make.";
            return new Weapon(new Item("Net", "", 1, 3),
                ProficiencyGroupType.Martial, CategoryType.Ranged,
                new Damage(DieType.d0, 1, DamageCategoryType.Bludgeoning))
            {
                SpecialNote = note,
                IsThrown = true,
                Range = new Range(5, 15),
            };
        }

        #endregion

        public ProficiencyGroupType ProficiencyGroup { get; private set; }
        public CategoryType Category { get; private set; }
        public Damage Damage { get; private set; }

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

        public Weapon(Item item, ProficiencyGroupType type, CategoryType category, Damage damage) : base(item)
        {
            this.ProficiencyGroup = type;
            this.Category = category;
            this.Damage = damage;
        }
    }
}
