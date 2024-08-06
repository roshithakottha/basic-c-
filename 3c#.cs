using System;

class HelloWorld
{
    static void Main()
    {
        int number = 2;
        switch (number)
        {
        case 1:
            Console.WriteLine("one:");
            break;
        case 2:
            Console.WriteLine("two:");
            break;
        case 3:
            Console.WriteLine("three:");
            break;
        default:
            Console.WriteLine("number not recognized:");
            break;
        }
    }
}