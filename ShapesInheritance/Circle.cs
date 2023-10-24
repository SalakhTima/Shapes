namespace ShapesInheritance;

internal class Circle : Circuit
{
    public override string Name => nameof(Circle);
    public Circle(double radius, double x, double y) : base(radius, x, y)
    { }
    public override double GetSize()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}