namespace ShapesInheritance;

internal class Program
{
    private static void Main()
    {
        Circle circle = new Circle(15, 1, 1);
        Console.WriteLine(circle.GetSize());

        Point point = circle;
        Console.WriteLine(point.GetName());

        Shape shape = circle;
        Console.WriteLine(shape.GetSize());

        Orb orb = new Orb(11, 2, 3);
        Console.WriteLine(orb.Center);
        Console.WriteLine(orb.Radius);
        Console.WriteLine(orb.GetSize());
    }
}