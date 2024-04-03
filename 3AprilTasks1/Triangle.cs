class Triangle:Shape
{
    private double a;
   // private double b;
    private double h;

    public Triangle(double a,double h){
        this.a=a;
        //this.b=b;
        this.h=h;
    }

    public override double CalculateArea(){
        return (a*h)/2;
    }
}