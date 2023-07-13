using ShapesLibrary.Models;

namespace ShapesLibrary.Tests;

public class CircleTests
{
    [Test]
    public void ValidCircleCreation()
    {
        // Arrange
        const double radius = 5;

        // Act
        var circle = new Circle(radius);

        // Assert
        Assert.That(circle.Radius, Is.EqualTo(radius));
    }

    [Test]
    public void InvalidCircleCreation()
    {
        // Arrange
        const double radius = -2;

        // Act & Assert
        Assert.Throws<ArgumentException>(() =>
        {
            var circle = new Circle(radius);
        });
    }

    [Test]
    public void DiameterCalculation()
    {
        // Arrange
        const double radius = 5;
        
        var circle = new Circle(radius);

        // Act
        var diameter = circle.Diameter;

        // Assert
        const double expectedDiameter = 2 * radius;
        Assert.That(diameter, Is.EqualTo(expectedDiameter));
    }

    [Test]
    public void PerimeterCalculation()
    {
        // Arrange
        const double radius = 5;
        
        var circle = new Circle(radius);

        // Act
        var perimeter = circle.Perimeter;

        // Assert
        const double expectedPerimeter = 2 * Math.PI * radius;
        Assert.That(perimeter, Is.EqualTo(expectedPerimeter));
    }

    [Test]
    public void SquareCalculation()
    {
        // Arrange
        const double radius = 5;
        var circle = new Circle(radius);

        // Act
        var square = circle.Square;

        // Assert
        const double expectedSquare = Math.PI * radius * radius;
        Assert.That(square, Is.EqualTo(expectedSquare));
    }
}