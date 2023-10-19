namespace ShapesAggregation;

internal class Program
{
    private static void Main()
    {
        var point = new Point(13, 81);
        Console.WriteLine(point.GetName());

        var circuit = new Circuit(point, 20);
        Console.WriteLine(circuit.Radius);

        var circle = new Circle(circuit);
        Console.WriteLine(circle.GetName());

        var sphere = new Sphere(circle);
        Console.WriteLine(sphere.Outline.Contour.Center);

        var orb = new Orb(sphere);
        Console.WriteLine(orb.GetSize());
    }
}