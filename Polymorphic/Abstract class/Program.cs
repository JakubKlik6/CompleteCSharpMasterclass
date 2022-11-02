using Csharp_Study;

Shape[] shapes = { new Sphere(4), new Cube(5) };

foreach (Shape shape in shapes)
{
    shape.GetInfo();
    Console.WriteLine($"{shape.Name} has volume of {shape.Volume()}");

    Cube iceCube = shape as Cube;
    if (iceCube == null)
        Console.WriteLine("This is no a Cube");
    if (iceCube is Cube)
        Console.WriteLine("This is a cube");

    object cube1 = new Cube(7);
    Cube cube2 = (Cube)cube1;

    Console.WriteLine($"\n{cube2.Name} has a Volume of {cube2.Volume()}");

}
