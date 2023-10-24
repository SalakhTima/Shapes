namespace ShapesAggregation;

internal class Orb : IShape
{
    public string Name => nameof(Orb);
    public Sphere Core { get; }
    public Orb(Sphere sphere)
    {
        Core = sphere;
    }
    public double GetSize()
    {
        return 4.0 / 3.0 * Math.PI * Math.Pow(Core.Outline.Contour.Radius, 3);
    }
}