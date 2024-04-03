internal class Program
{
    public static void Main(string[] args)
    {
    //  Implement a class hierarchy representing different shapes such as Circle, 
    //  Square, and Triangle. Use abstraction to 
    //  create a base class called Shape with an abstract method CalculateArea().
    //   Then, derive specific shape classes from Shape and implement 
    //  CalculateArea() in each subclass according to the shape's formula.
    Circle circle=new Circle(5);
    System.Console.WriteLine("Area of Circle: "+circle.CalculateArea());

    Square square=new Square(4);
    System.Console.WriteLine("Area of Square: "+square.CalculateArea());

    Triangle triangle=new Triangle(3,5);
    System.Console.WriteLine("Area of Triangle: "+triangle.CalculateArea());

    }
}