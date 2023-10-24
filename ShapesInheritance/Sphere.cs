namespace ShapesInheritance;

internal class Sphere : Circle
{
    public override string Name => nameof(Sphere);
    public Sphere(double radius, double x, double y) : base(radius, x, y)
    { }
    public override double GetSize()
    {
        return 4 * Math.PI * Math.Pow(Radius, 2);
    }
}