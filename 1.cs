using System;

class rectangle
{
       public double Length { get; set; }
       public double Width { get; set; }
    public rectangle(double l,double w)
       {
           Length=l;
           Width =w;
       }
       public double Area()
       {
           return Length * Width;
       }
}
class Area{
    static void Main()
    {
        rectangle r = new rectangle(3.0, 5.0);
        double a = r.Area();
        Console.WriteLine("The area of the rectangle is: " + a);
    }
}