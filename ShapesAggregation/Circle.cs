namespace ShapesAggregation;

internal class Circle : IShape
{
    public Circuit Contour { get; set; }
    public Circle(Circuit circuit)
    {
        Contour = circuit;
    }
    public double GetSize()
    {
        return Math.PI * Math.Pow(Contour.Radius, 2);
    }
    public string GetName()
    {
        return nameof(Circle);
    }
}