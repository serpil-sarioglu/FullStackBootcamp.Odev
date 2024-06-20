namespace SOLID.OCP;

public abstract class Shape
{
    public abstract double CalculateArea();
}
public class Circle : Shape
{
    public double Radius { get; set; }
    public Circle(double radius)
    {
        Radius = radius;
    }
    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }
    public override double CalculateArea()
    {
        return Width * Height;
    }
}

public class AreaCalculator
{
    public double CalculateArea(Shape shape)
    {
        return shape.CalculateArea();
    }
}
    
