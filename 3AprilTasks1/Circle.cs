using System.Security.Cryptography.X509Certificates;

class Circle:Shape
{
    private double radius;
    public  Circle(double radius){
        this.radius=radius;
    }
    public override double CalculateArea()
    {
        return Math.PI*radius*radius;
    }
}