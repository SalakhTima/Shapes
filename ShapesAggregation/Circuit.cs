namespace ShapesAggregation;

internal class Circuit : IShape
{
    public Point Center { get; set; }
    public double Radius { get; set; }
    public Circuit(Point point, double radius)
    {
        Center = point;
        Radius = radius;
    }
    public double GetSize()
    {
        return 2 * Math.PI * Radius;
    }
    public string GetName()
    {
        return nameof(Circuit);
    }
}