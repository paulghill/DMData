namespace DMData.Items
{
    public class Item : IItem
    {
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public double Value { get; protected set; }
        public double Weight { get; protected set; }

        public Item(string name, string description, double value, double weight)
        {
            this.Name = name;
            this.Description = description;
            this.Value = value;
            this.Weight = weight;
        }
        public Item(Item item)
        {
            if (item == null)
            {
                this.Description = "";
                this.Name = "";
                this.Value = 0;
                this.Weight = 0;
            }
            else
            {
                this.Description = item.Description;
                this.Name = item.Name;
                this.Value = item.Value;
                this.Weight = item.Weight;
            }
        }
    }
}
