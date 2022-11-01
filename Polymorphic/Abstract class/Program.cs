using Csharp_Study;

Shape[] shapes = { new Sphere(4), new Cube(5) };

foreach (Shape shape in shapes)
{
    shape.GetInfo();
    Console.WriteLine($"{shape.Name} has volume of {shape.Volume()}");
}