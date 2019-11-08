using System;
using System.Text;

namespace DMData.Movement
{
    public struct MovementInfo : IEquatable<MovementInfo>
    {
        public MovementType Type { get; private set; }
        public int Speed { get; private set; }

        public MovementInfo(MovementType category, int speed)
        {
            Type = category;
            Speed = speed;
        }

        public string GetDisplayMovementValue()
        {
            var output = new StringBuilder();
            output.Append(Speed);
            output.Append("ft. ");
            output.Append(Type);

            return output.ToString();
        }

        public int GetDifficultTerrain()
        {
            double output = Speed / 2;
            return (int)Math.Round(output, 0, MidpointRounding.ToEven);
        }
        public int GetSwimmingClimbingCrawling(TerrainType terrain)
        {
            int difficultyMultiplier = 0;

            if (terrain == TerrainType.Normal) { difficultyMultiplier = 2; }
            else { difficultyMultiplier = 3; }

            double output = Speed / difficultyMultiplier;
            return (int)Math.Round(output, 0, MidpointRounding.ToEven);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !GetType().Equals(obj.GetType())) { return false; }
            else { return Equals((MovementInfo)obj); }
        }
        public bool Equals(MovementInfo other)
        {
            return Type == other.Type && Speed == Speed;
        }

        public override int GetHashCode()
        {
            return Tuple.Create(Type, Speed).GetHashCode();
        }

        public static bool operator ==(MovementInfo left, MovementInfo right)
        {
            return left.Equals(right);
        }
        public static bool operator !=(MovementInfo left, MovementInfo right)
        {
            return !(left == right);
        }
    }
}

