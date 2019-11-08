using System;

namespace DMData.Movement
{
    public struct MovementModifier : IEquatable<MovementModifier>
    {
        public MovementType Type { get; private set; }
        public int Adjustment { get; private set; }
        public string Name { get; private set; }

        public MovementModifier(MovementType type, int speedAdjustment, string name)
        {
            Type = type;
            Adjustment = speedAdjustment;
            Name = name;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || !GetType().Equals(obj.GetType())) { return false; }
            else { return Equals((MovementModifier)obj); }
        }
        public bool Equals(MovementModifier other)
        {
            return Type == other.Type &&
                Adjustment == other.Adjustment &&
                Name == other.Name;
        }

        public override int GetHashCode()
        {
            return Tuple.Create(Name, Type, Adjustment).GetHashCode();
        }

        public static bool operator ==(MovementModifier left, MovementModifier right)
        {
            return left.Equals(right);
        }
        public static bool operator !=(MovementModifier left, MovementModifier right)
        {
            return !(left == right);
        }
    }
}

