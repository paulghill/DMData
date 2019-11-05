namespace DMData.Items
{
    public interface IItem
    {
        string Name { get; }
        string Description { get; }
        double Value { get; }
        double Weight { get; }
    }
}
