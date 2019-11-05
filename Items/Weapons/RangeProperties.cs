namespace DMData.Items.Weapons
{
    public sealed class RangeProperties
    {
        public bool HasLoading { get; private set; }
        public bool HasBurstFire { get; private set; }
        public Ammunition Ammunition { get; private set; }
        public bool HasReload { get; private set; }
        public int ReloadShots { get; private set; }

        public RangeProperties(Ammunition ammunition)
        {
            this.HasLoading = false;
            this.Ammunition = ammunition;
            this.HasReload = false;
            this.ReloadShots = 0;
            this.HasBurstFire = false;
        }
        public RangeProperties(Ammunition ammunition, bool loading)
        {
            this.HasLoading = loading;
            this.Ammunition = ammunition;
            this.HasReload = false;
            this.ReloadShots = 0;
            this.HasBurstFire = false;
        }
        public RangeProperties(Ammunition ammunition, int shots, bool burstFire)
        {
            this.HasLoading = false;
            this.Ammunition = ammunition;
            this.HasReload = true;
            this.ReloadShots = shots;
            this.HasBurstFire = burstFire;
        }
    }
}
