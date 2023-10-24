namespace ShapesAggregation;

internal class Circle : IShape
{
    public string Name => nameof(Circle);
    public double Radius => Contour.Radius;
    public Circuit Contour { get; }
    public Circle(double x, double y, double radius)
    {
        Contour = new Circuit(x, y, radius);
    }
    public double GetSize()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}