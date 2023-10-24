namespace ShapesAggregation;

internal class Program
{
    private static void Main()
    {
        var point = new Point(13, 81);
        Console.WriteLine(point.Name);

        var circuit = new Circuit(5, 10, 20);
        Console.WriteLine(circuit.Radius);

        var circle = new Circle(1, 2, 7);
        Console.WriteLine(circle.Name);

        var sphere = new Sphere(7, 9, 19);
        Console.WriteLine(sphere);

        var orb = new Orb(8, 11, 20);
        Console.WriteLine(orb.GetSize());
    }
}