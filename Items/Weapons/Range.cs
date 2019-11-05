namespace DMData.Items.Weapons
{
    public sealed class Range
    {
        public int Normal { get; private set; }
        public int Max { get; private set; }

        public Range(int range, int rangeMax)
        {
            this.Normal = range;
            this.Max = rangeMax;
        }
    }
}
