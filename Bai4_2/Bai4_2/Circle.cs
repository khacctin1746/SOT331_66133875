namespace Bai4_2;

public class Circle : Shape
{
    private double radius;
    // private string name;
    
    public Circle(double radius, string name)
    {
        this.radius = radius; 
        this.name = name;
    }

    public override double Area()
    {
        return Math.PI * radius * radius;
    }

    public override string Name()
    {
        return name;
    }

    public double getRadius()
    {
        return radius;
    }
}