using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMData
{
    public struct Damage : IEquatable<Damage>
    {
        public DieType Die { get; private set; }
        public int NumberOfDice { get; private set; }
        public DamageType DamageCategory { get; private set; }

        public Damage(DieType die, int number, DamageType type)
        {
            this.Die = die;
            this.NumberOfDice = number;
            this.DamageCategory = type;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType())) { return false; }
            else { return this.Equals((Damage)obj); }
        }
        public bool Equals(Damage other)
        {
            return this.DamageCategory == other.DamageCategory &&
                this.Die == other.Die &&
                this.NumberOfDice == other.NumberOfDice;
        }

        public override int GetHashCode()
        {
            return Tuple.Create(this.DamageCategory, this.Die, this.NumberOfDice).GetHashCode();
        }

        public static bool operator ==(Damage left, Damage right)
        {
            return left.Equals(right);
        }
        public static bool operator !=(Damage left, Damage right)
        {
            return !(left == right);
        }
    }
}
