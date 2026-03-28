namespace Bai4_2;

public class Triangle : Shape
{
    // private string name;
    private double a;
    private double b;
    private double c;
    
    public Triangle(string name, double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
        this.name = name;
    }

    public override double Area()
    {
        double p = (a + b + c) / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

    public override string Name()
    {
        return name;
    }
    
    public double getA()
    {
        return a;
    }

    public double getB()
    {
        return b;
    }

    public double getC()
    {
        return c;
    }
}