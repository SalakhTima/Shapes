namespace ShapesInheritance;

internal class Circle : Circuit
{
    public Circuit Contour { get; set; }
    public Circle(double radius, double x, double y) : base(radius, x, y)
    {
        Contour = new Circuit(radius, x, y);
    }
    public override double GetSize()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
    public override string GetName()
    {
        return nameof(Circle);
    }
}