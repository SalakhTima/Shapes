namespace ShapesInheritance;

internal class Circle : Circuit
{
    public override string Name => nameof(Circle);
    public Circuit Contour { get; }
    public Circle(double radius, double x, double y) : base(radius, x, y)
    {
        Contour = new Circuit(radius, x, y);
    }
    public override double GetSize()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}