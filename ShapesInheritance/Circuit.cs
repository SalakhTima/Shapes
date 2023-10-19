namespace ShapesInheritance;

internal class Circuit : Point
{
    public Point Center { get; set; }
    public double Radius { get; set; }
    public Circuit(double radius, double x, double y) : base(x, y)
    {
        Center = new Point(x, y);
        Radius = radius;
    }
    public override double GetSize()
    {
        return 2 * Math.PI * Radius;
    }
    public override string GetName()
    {
        return nameof(Circuit);
    }
}