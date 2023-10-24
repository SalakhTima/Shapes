namespace ShapesInheritance;

internal class Orb : Sphere
{
    public override string Name => nameof(Orb);
    public Orb(double radius, double x, double y) : base(radius, x, y)
    { }
    public override double GetSize()
    {
        return 4.0 / 3.0 * Math.PI * Math.Pow(Radius, 3);
    }
}