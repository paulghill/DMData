using System;

namespace DMData.Names
{
    public struct RandomName : IEquatable<RandomName>
    {
        public NameCategoryType Category { get; private set; }
        public NameGenderType Gender { get; private set; }
        public string GivenName { get; private set; }
        public string Surname { get; private set; }

        public RandomName(NameCategoryType nameCategoryType, NameGenderType nameGenderType, string givenName, string surname)
        {
            this.Category = nameCategoryType;
            this.Gender = nameGenderType;
            this.GivenName = givenName;
            this.Surname = surname;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType())) { return false; }
            else { return this.Equals((RandomName)obj); }
        }
        public bool Equals(RandomName other)
        {
            return (this.Category == other.Category) &&
                (this.Gender == other.Gender) &&
                (this.GivenName == other.GivenName) &&
                (this.Surname == other.Surname);
        }

        public override int GetHashCode()
        {
            return Tuple.Create(this.Category, this.Gender, this.GivenName, this.Surname).GetHashCode();
        }

        public static bool operator ==(RandomName left, RandomName right)
        {
            return left.Equals(right);
        }
        public static bool operator !=(RandomName left, RandomName right)
        {
            return !(left == right);
        }
    }
}
