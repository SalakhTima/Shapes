namespace ShapesInheritance;

internal class Orb : Sphere
{
    public Sphere Core { get; set; }
    public Orb(double radius, double x, double y) : base(radius, x, y)
    {
        Core = new Sphere(radius, x, y);
    }
    public override double GetSize()
    {
        return 4.0 / 3.0 * Math.PI * Math.Pow(Radius, 3);
    }
    public override string GetName()
    {
        return nameof(Orb);
    }
}