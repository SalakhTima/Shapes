namespace ShapesAggregation;

internal class Sphere : IShape
{
    public string Name => nameof(Sphere);
    public double Radius => Outline.Radius;
    public Circle Outline { get; }
    public Sphere(double x, double y, double radius)
    {
        Outline = new Circle(x, y, radius);
    }
    public double GetSize()
    {
        return 4 * Math.PI * Math.Pow(Radius, 2);
    }
}