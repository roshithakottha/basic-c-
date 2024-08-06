using System;
class program{
  static void Main() {
    int num=Convert.ToInt32(Console.ReadLine());
    int i=2,n=0;
    while(i<num)
    {
        if(num%i==0)
        {
            n=n+1;
        }
        i=i+1;
    }
    if(n==0)
        Console.WriteLine(+num+" is prime");
    else
        Console.WriteLine(+num+" is not prime");
  }
}