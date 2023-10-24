namespace ShapesInheritance;

internal class Point : Shape
{
    public override string Name => nameof(Point);
    public double X { get; }
    public double Y { get; }
    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }
    public override double GetSize()
    {
        return 0;
    }
}