using System;

namespace DMData.Names
{
    public struct Nobility : IEquatable<Nobility>
    {
        public NobilityCategoryType Category { get; private set; }
        public NameGenderType Gender { get; private set; }
        public int Ranking { get; private set; }
        public string Title { get; private set; }

        public Nobility(NobilityCategoryType category, NameGenderType gender, int ranking, string title)
        {
            this.Category = category;
            this.Gender = gender;
            this.Ranking = ranking;
            this.Title = title;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType())) { return false; }
            else { return this.Equals((Nobility)obj); }
        }
        public bool Equals(Nobility other)
        {
            return (this.Category == other.Category) &&
                (this.Gender == other.Gender) &&
                (this.Ranking == other.Ranking) &&
                (this.Title == other.Title);
        }

        public override int GetHashCode()
        {
            return Tuple.Create(this.Category, this.Gender, this.Ranking, this.Title).GetHashCode();
        }

        public static bool operator ==(Nobility left, Nobility right)
        {
            return left.Equals(right);
        }
        public static bool operator !=(Nobility left, Nobility right)
        {
            return !(left == right);
        }
    }
}
