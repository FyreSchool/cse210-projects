public class Circle : Shape
{
    private double radius;

    public Circle(string color, double radius) : base(color)
    {
        this.radius = radius;
    }

    public override double Area()
    {
    
        double circleArea = 3.14 * (radius * radius);
        return circleArea;
    }
};
