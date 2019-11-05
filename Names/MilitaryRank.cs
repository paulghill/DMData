using System;

namespace DMData.Names
{
    public struct MilitaryRank : IEquatable<MilitaryRank>
    {
        public MilitaryGradeType Grade { get; private set; }
        public string Rank { get; private set; }

        public MilitaryRank(MilitaryGradeType grade, string rank)
        {
            this.Grade = grade;
            this.Rank = rank;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType())) { return false; }
            else { return this.Equals((MilitaryRank)obj); }
        }
        public bool Equals(MilitaryRank other)
        {
            return (this.Grade == other.Grade) && (this.Rank == other.Rank);
        }

        public override int GetHashCode()
        {
            return Tuple.Create(this.Grade, this.Rank).GetHashCode();
        }

        public static bool operator ==(MilitaryRank left, MilitaryRank right)
        {
            return left.Equals(right);
        }
        public static bool operator !=(MilitaryRank left, MilitaryRank right)
        {
            return !(left == right);
        }
    }
}
