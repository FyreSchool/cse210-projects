using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square shape1 = new Square("Blue",5 );
        Rectangle shape2 = new Rectangle("Orange", 8 ,2);
        Circle shape3 = new Circle("Yellow", 9);

        shapes.Add(shape1);
        shapes.Add(shape2);
        shapes.Add(shape3);

        foreach (Shape i in shapes)
        {
            string color = i.Color();
            double area = i.Area();

            Console.WriteLine($"The shape that is {color} has an area of {area}. ");
        }
    }
}