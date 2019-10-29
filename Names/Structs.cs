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
    public struct Title : IEquatable<Title>
    {
        public NameGenderType Gender { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }

        public Title(NameGenderType gender, string name, string description)
        {
            this.Gender = gender;
            this.Name = name;
            this.Description = description;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType())) { return false; }
            else { return this.Equals((Title)obj); }
        }
        public bool Equals(Title other)
        {
            if (other == null) { return false; }
            else
            {
                return (this.Description == other.Description) &&
                    (this.Gender == other.Gender) &&
                    (this.Name == this.Name);
            }
        }

        public override int GetHashCode()
        {
            return Tuple.Create(this.Gender, this.Name, this.Description).GetHashCode();
        }

        public static bool operator ==(Title left, Title right)
        {
            return left.Equals(right);
        }
        public static bool operator !=(Title left, Title right)
        {
            return !(left == right);
        }

    }
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
