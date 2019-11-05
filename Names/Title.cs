using System;

namespace DMData.Names
{
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
}
