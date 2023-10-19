namespace ShapesAggregation;

internal class Point : IShape
{
    public double X { get; set; }
    public double Y { get; set; }
    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }
    public double GetSize()
    {
        return 0;
    }
    public string GetName()
    {
        return nameof(Point);
    }
}