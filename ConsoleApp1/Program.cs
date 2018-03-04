using System;

namespace RectangleArea
{
    class Rectarea
    {
        static void Main()
        {
            Console.Write("Enter the length:");
            int length = int.Parse(Console.ReadLine());
            Console.Write("Enter the breadth:");
            int breadth = int.Parse(Console.ReadLine());
            Console.Write("the area is: {0}", length * breadth);
            Console.Read();
        }
    }
}