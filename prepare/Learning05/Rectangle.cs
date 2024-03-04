public class Rectangle : Shape
{
    private float sideWidth;
    private float sideLength;

    public Rectangle(string color, float sideWidth, float sideLength) : base(color)
    {
        this.sideLength = sideLength;
        this.sideWidth = sideWidth;
    }

    public override double Area()
    {
        double rectangleArea= sideLength * sideWidth;
        return rectangleArea;
    }
}