namespace ShapesLibrary.Models;

public class Triangle : Shape
{
    private readonly double _side1, _side2, _side3;

    public double Side1
    {
        get => _side1;
        private init
        {
            if (value > 0)
            {
                _side1 = value;
            }
            else
            {
                throw new ArgumentException("Длина стороны треугольника должна быть положительным числом.");
            }
        }
    }
    
    public double Side2
    {
        get => _side2;
        private init
        {
            if (value > 0)
            {
                _side2 = value;
            }
            else
            {
                throw new ArgumentException("Длина стороны треугольника должна быть положительным числом.");
            }
        }
    }
    
    public double Side3
    {
        get => _side3;
        private init
        {
            if (value > 0)
            {
                _side3 = value;
            }
            else
            {
                throw new ArgumentException("Длина стороны треугольника должна быть положительным числом.");
            }
        }
    }
    
    public Triangle(double side1, double side2, double side3)
    {
        if (IsValidTriangle(side1, side2, side3))
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }
        else
        {
            throw new ArgumentException("Треугольника с такими сторонами не существует.");
        }
    }
    
    private static bool IsValidTriangle(double side1, double side2, double side3)
    {
        return side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1;
    }
    
    public bool IsRightTriangle()
    {
        const double tolerance = 0.0000001;
        
        var maxSide = Math.Max(Side1, Math.Max(Side2, Side3));
        
        return maxSide switch
        {
            _ when Math.Abs(maxSide - Side1) < tolerance => Math.Abs(Side1 * Side1 - (Side2 * Side2 + Side3 * Side3)) < tolerance, 
            _ when Math.Abs(maxSide - Side2) < tolerance => Math.Abs(Side2 * Side2 - (Side1 * Side1 + Side3 * Side3)) < tolerance, 
            _ => Math.Abs(Side3 * Side3 - (Side1 * Side1 + Side2 * Side2)) < tolerance 
        }; 
    }
    
    public override double Perimeter => Side1 + Side2 + Side3;
    
    public override double Square
    {
        get
        {
            var semiperimeter = Perimeter / 2;

            return Math.Sqrt(
                semiperimeter *
                (semiperimeter - Side1) *
                (semiperimeter - Side2) *
                (semiperimeter - Side3)
                );
        }
    }
}