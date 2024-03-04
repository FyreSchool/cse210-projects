public abstract class Shape
{
    private string color;

    public Shape(string color)
    {
        this.color = color;
    }

    public string Color()
    {
        return color;
    }


    public abstract double Area();

}