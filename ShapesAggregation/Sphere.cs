namespace ShapesAggregation;

internal class Sphere : IShape
{
    public Circle Outline { get; set; }
    public Sphere(Circle circle)
    {
        Outline = circle;
    }
    public double GetSize()
    {
        return 4 * Math.PI * Math.Pow(Outline.Contour.Radius, 2);
    }
    public string GetName()
    {
        return nameof(Sphere);
    }
}