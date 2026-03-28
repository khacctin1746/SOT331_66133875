namespace Bai4_2;

public class Rectangle : Shape
{
    private double width;
    private double height;
    // private string name;

    public Rectangle(double height, double width, string name)
    {
        this.height = height;
        this.width = width;
        this.name = name;
    }

    public double getHeight()
    {
        return height;
    }

    public double getWidth()
    {
        return width;
    }
    
    public override double Area()
    {
        return width * height;
    }

    public override string Name()
    {
        return name;
    }
}    