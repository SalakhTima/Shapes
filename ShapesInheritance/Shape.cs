namespace ShapesInheritance;

internal abstract class Shape
{
    public virtual string Name => nameof(Shape);
    public virtual double GetSize()
    {
        return default;
    }
}