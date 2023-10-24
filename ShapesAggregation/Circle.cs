namespace ShapesAggregation;

internal class Circle : IShape
{
    public string Name => nameof(Circle);
    public Circuit Contour { get; }
    public Circle(Circuit circuit)
    {
        Contour = circuit;
    }
    public double GetSize()
    {
        return Math.PI * Math.Pow(Contour.Radius, 2);
    }
}