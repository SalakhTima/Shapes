namespace ShapesAggregation;

internal class Sphere : IShape
{
    public string Name => nameof(Sphere);
    public Circle Outline { get; }
    public Sphere(Circle circle)
    {
        Outline = circle;
    }
    public double GetSize()
    {
        return 4 * Math.PI * Math.Pow(Outline.Contour.Radius, 2);
    }
}