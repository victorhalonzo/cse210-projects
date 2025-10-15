using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");



        Square squartle = new Square("blue", 5.2);

        Console.WriteLine(squartle.GetColor());
        Console.WriteLine(squartle.GetArea());

        Rectangle rectangle = new Rectangle("green", 10.4, 6.3);
        Console.WriteLine(rectangle.GetColor());
        Console.WriteLine(rectangle.GetArea());

        Circle circle = new Circle("red", 5.6);
        Console.WriteLine(circle.GetColor());
        Console.WriteLine(circle.GetArea());

        List<Shape> shapes = new List<Shape>();
        shapes.Add(squartle);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"My color is: {shape.GetColor()}");
            Console.WriteLine($"My area is: {shape.GetArea()}");
        }
    }

}