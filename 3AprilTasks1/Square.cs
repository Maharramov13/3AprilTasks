class Square:Shape
{
    private double a;

    public Square(double a){
        this.a=a;
        
    }
    public override double CalculateArea()
    {
        return a*a;
    }

}