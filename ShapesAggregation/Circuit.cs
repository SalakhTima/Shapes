namespace ShapesAggregation;

internal class Circuit : IShape
{
    public string Name => nameof(Circuit);
    public double Radius { get; }
    public Point Center { get; }
    public Circuit(double x, double y, double radius)
    {
        Center = new Point(x, y);
        Radius = radius;
    }
    public double GetSize()
    {
        return 2 * Math.PI * Radius;
    }
}