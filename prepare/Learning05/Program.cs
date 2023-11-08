using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square(15, "blue");
        Console.WriteLine(square.GetArea());

        Rectangle rectangle = new Rectangle(15, 10, "black");
        Console.WriteLine(rectangle.GetArea());

        Circle circle = new Circle(15, "red");
        Console.WriteLine(circle.GetArea());


        List<Shape> shapes = new List<Shape> { square, rectangle, circle };
        

        shapes.ForEach(
            it =>
            {
            String color = it.Color;
            Double area = it.GetArea();

            Console.WriteLine($"color - {color}, area - {area}");
        });

    }
}