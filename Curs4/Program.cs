using System;

namespace Curs4
{
    class Program
    {
        public static double calculateArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        public static double calculateArea(int width, int length)
        {
            return width*length;
        }
        public static double calculateArea(double radius,double height)
        {
            return 2 * Math.PI * radius * height + 2 * Math.PI * Math.Pow(radius, 2);
        }
    }
    class Program2
    {
        static void Main(string[] args)
        {
            while (true) { 
            Console.WriteLine("1.Calculate the area of a circle");
            Console.WriteLine("2.Calculate the area of a rectangle");
            Console.WriteLine("3.Calculate the area of a cylinder");
            int choice = Int32.Parse(Console.ReadLine());
                switch (choice) {
                    case 1:
                        Console.Write("Input the radius: ");
                        double radius = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Area is :"+Program.calculateArea(radius));
                        break;
                    case 2:
                        Console.Write("Input the width: ");
                        int width = Int32.Parse(Console.ReadLine());
                        Console.Write("Input the length: ");
                        int length = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Area is :" + Program.calculateArea(width, length));
                        break;
                    case 3:
                        Console.Write("Input the radius: ");
                        radius = Double.Parse(Console.ReadLine());
                        Console.Write("Input the height: ");
                        double height = Double.Parse(Console.ReadLine());
                        Console.Write("Area is : "+Program.calculateArea(radius, height));
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
