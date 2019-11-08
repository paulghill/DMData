using System;

namespace DMData
{
    public struct Sense : IEquatable<Sense>
    {
        public SenseType Type { get; private set; }
        public string Name { get; private set; }
        public int Range { get; private set; }
        public bool HasNotes { get; private set; }
        public string Notes { get; private set; }

        public Sense(SenseType type, string name, int range, string notes)
        {
            this.Type = type;
            this.Name = name;
            this.Range = range;
            this.HasNotes = true;
            this.Notes = notes;
        }
        public Sense(SenseType type, string name, int range)
        {
            this.Type = type;
            this.Name = name;
            this.Range = range;
            this.HasNotes = false;
            this.Notes = "";
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType())) { return false; }
            { return this.Equals((Sense)obj); }
        }
        public bool Equals(Sense other)
        {
            return this.Range == other.Range &&
                this.Type == other.Type &&
                this.Name == other.Name &&
                this.Notes == other.Notes &&
                this.HasNotes == other.HasNotes;
        }

        public override int GetHashCode()
        {
            return Tuple.Create(this.Range, this.Type, this.HasNotes, this.Notes, this.Name).GetHashCode();
        }

        public static bool operator ==(Sense left, Sense right)
        {
            return left.Equals(right);
        }
        public static bool operator !=(Sense left, Sense right)
        {
            return !(left == right);
        }
    }
}
