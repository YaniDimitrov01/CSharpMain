// See https://aka.ms/new-console-template for more information
using System;

// Дефиниране на interface
public interface IShape
{
    double CalculateArea(); // внедряващите /наследяващите/ този интерфейс 
                            // класове задължително трябва да имат 
                            // този метод /договор/
}

// Внедряване на интерфейса IShape в клас Circle 
public class Circle : IShape
{
    private double radius;
    public Circle(double radius)  // конструктор на клас Circle
    {
        this.radius = radius;
    }
    public double CalculateArea() // IShape ни "задължава" да имаме такъв метод
    {                             // в класа Circle, чрез "договор"
        return Math.PI * Math.Pow(radius, 2);
    }
}


// Внедряване на интерфейса IShape в клас Rectangle  
public class Rectangle : IShape 
{
    private double width;
    private double height;

    public Rectangle(double width, double height) // конструктор на клас Rectangle
    {
        this.width = width;
        this.height = height;
    }

    public double CalculateArea() // IShape ни "задължава" да имаме такъв метод
    {                             // в класа Rectangle, чрез "договор"
        return width * height;
    }
}

// Употреба на интерфейс
public class Program
{
    public static void Main()
    {
        // Създаване на 2 обекта, които внедряват интерфейса IShape  
        // с new ги създаваме от различни класове
        IShape circle = new Circle(5); // и 2-та обекта са тип IShape 
        IShape rectangle = new Rectangle(4, 6);   
         
       
        // Извикваме метода на interface на различни обекти:
        // 1. извиква се метод CalculateArea от клас Circle:
        double circleArea = circle.CalculateArea();

        // 2. извиква се метод CalculateArea от клас Rectangle:
        double rectangleArea = rectangle.CalculateArea();

        // 3.извеждане на резултата
        Console.WriteLine("Circle area: " + circleArea);
        Console.WriteLine("Rectangle area: " + rectangleArea);
    }
}

// Резултат:
// Circle area: 78.53981633974483
// Rectangle area: 24
