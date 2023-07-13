namespace ShapesLibrary.Models;

public class Circle : Shape
{
    private readonly double _radius;
    
    public double Radius
    {
        get => _radius;
        private init
        {
            if (value > 0)
            {
                _radius = value;
            }
            else
            {
                throw new ArgumentException("Длина радиуса должна быть положительным числом.");
            }
        }
    }
    
    public Circle(double radius)
    {
        Radius = radius;
    }

    public double Diameter => 2 * Radius;
    
    public override double Perimeter => 2 * Math.PI * Radius;
    
    public override double Square => Math.PI * Radius * Radius;
}