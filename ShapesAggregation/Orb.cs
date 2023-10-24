namespace ShapesAggregation;

internal class Orb : IShape
{
    public string Name => nameof(Orb);
    public double Radius => Core.Radius;
    public Sphere Core { get; }
    public Orb(double x, double y, double radius)
    {
        Core = new Sphere(x, y, radius);
    }
    public double GetSize()
    {
        return 4.0 / 3.0 * Math.PI * Math.Pow(Radius, 3);
    }
}