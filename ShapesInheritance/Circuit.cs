namespace ShapesInheritance;

internal class Circuit : Point
{
    public override string Name => nameof(Circuit);
    public Point Center { get; }
    public double Radius { get; }
    public Circuit(double radius, double x, double y) : base(x, y)
    {
        Center = new Point(x, y);
        Radius = radius;
    }
    public override double GetSize()
    {
        return 2 * Math.PI * Radius;
    }
}