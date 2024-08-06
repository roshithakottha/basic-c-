using System;
class hi
    {
      static void Main()
      {
         int n=Convert.ToInt32(Console.ReadLine());
         int i=1;
         while(i<=10)
         {
             int m=n*i;
             Console.WriteLine(+n+"*"+i+"="+m);
             i++;
         }
             
      }
      
    }