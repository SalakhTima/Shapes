namespace ShapesInheritance;

internal class Sphere : Circle
{
    public override string Name => nameof(Sphere);
    public Circle Outline { get; }
    public Sphere(double radius, double x, double y) : base(radius, x, y)
    {
        Outline = new Circle(radius, x, y);
    }
    public override double GetSize()
    {
        return 4 * Math.PI * Math.Pow(Radius, 2);
    }
}