namespace ShapesInheritance;

internal class Sphere : Circle
{
    public Circle Outline { get; set; }
    public Sphere(double radius, double x, double y) : base(radius, x, y)
    {
        Outline = new Circle(radius, x, y);
    }
    public override double GetSize()
    {
        return 4 * Math.PI * Math.Pow(Radius, 2);
    }
    public override string GetName()
    {
        return nameof(Sphere);
    }
}