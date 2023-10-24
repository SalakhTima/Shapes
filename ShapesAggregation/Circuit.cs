namespace ShapesAggregation;

internal class Circuit : IShape
{
    public string Name => nameof(Circuit);
    public Point Center { get; }
    public double Radius { get; }
    public Circuit(Point point, double radius)
    {
        Center = point;
        Radius = radius;
    }
    public double GetSize()
    {
        return 2 * Math.PI * Radius;
    }
}