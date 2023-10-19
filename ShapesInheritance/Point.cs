namespace ShapesInheritance;

internal class Point : Shape
{
    public double X { get; set; }
    public double Y { get; set; }
    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }
    public override double GetSize()
    {
        return 0;
    }
    public override string GetName()
    {
        return nameof(Point);
    }
}