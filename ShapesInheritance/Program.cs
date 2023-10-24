namespace ShapesInheritance;

internal class Program
{
    private static void Main()
    {
        var circle = new Circle(15, 1, 1);
        Console.WriteLine(circle.GetSize());

        Point point = circle;
        Console.WriteLine(point.Name);

        Shape shape = circle;
        Console.WriteLine(shape.GetSize());

        var orb = new Orb(11, 2, 3);
        Console.WriteLine(orb.X + " " + orb.Y);
        Console.WriteLine(orb.Radius);
        Console.WriteLine(orb.GetSize());
    }
}