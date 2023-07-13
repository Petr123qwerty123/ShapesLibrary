using ShapesLibrary.Models;

namespace ShapesLibrary.Tests;

public class TriangleTests
{
    [Test]
    public void ValidTriangleCreation()
    {
        // Arrange
        const double side1 = 3;
        const double side2 = 4;
        const double side3 = 5;

        // Act
        var triangle = new Triangle(side1, side2, side3);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(triangle.Side1, Is.EqualTo(side1));
            Assert.That(triangle.Side2, Is.EqualTo(side2));
            Assert.That(triangle.Side3, Is.EqualTo(side3));
        });
    }
    
    [Test]
    public void InvalidTriangleCreation()
    {
        // Arrange
        const double side1 = 1;
        const double side2 = 2;
        const double side3 = 10;

        // Act & Assert
        Assert.Throws<ArgumentException>(() =>
        {
            var triangle = new Triangle(side1, side2, side3);
        });
    }

    [Test]
    public void RightTriangleCheck()
    {
        // Arrange
        const double side1 = 3;
        const double side2 = 4;
        const double side3 = 5;
        
        var triangle = new Triangle(side1, side2, side3);

        // Act
        var isRightTriangle = triangle.IsRightTriangle();

        // Assert
        Assert.That(isRightTriangle, Is.True);
    }

    [Test]
    public void NonRightTriangleCheck()
    {
        // Arrange
        const double side1 = 3;
        const double side2 = 4;
        const double side3 = 6;
        
        var triangle = new Triangle(side1, side2, side3);

        // Act
        var isRightTriangle = triangle.IsRightTriangle();

        // Assert
        Assert.That(isRightTriangle, Is.False);
    }

    [Test]
    public void PerimeterCalculation()
    {
        // Arrange
        const double side1 = 3;
        const double side2 = 4;
        const double side3 = 5;
        
        var triangle = new Triangle(side1, side2, side3);

        // Act
        var perimeter = triangle.Perimeter;

        // Assert
        var expectedPerimeter = side1 + side2 + side3;
        Assert.That(perimeter, Is.EqualTo(expectedPerimeter));
    }

    [Test]
    public void SquareCalculation()
    {
        // Arrange
        const double side1 = 3;
        const double side2 = 4;
        const double side3 = 5;
        
        var triangle = new Triangle(side1, side2, side3);

        // Act
        var square = triangle.Square;

        // Assert
        var semiperimeter = triangle.Perimeter / 2;
        var expectedSquare = Math.Sqrt(
            semiperimeter *
            (semiperimeter - side1) *
            (semiperimeter - side2) *
            (semiperimeter - side3)
        );
        Assert.That(square, Is.EqualTo(expectedSquare));
    }
}