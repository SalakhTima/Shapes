namespace ShapesAggregation;

internal interface IShape
{
    string Name { get; }
    double GetSize();
}