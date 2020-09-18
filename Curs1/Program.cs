using System;

namespace Curs1
{
   public static class Program
    {
       public static double surfaceOfCircle()
        {
            Console.WriteLine("Please specify the radius of the circle");
            double radius = Convert.ToDouble(Console.ReadLine());
            double surface = Math.PI * (radius * radius);

            Console.WriteLine("The surface of the circle is :");
            return surface;
        }
    }

    public static class Program2
    {
        public static double convertTemperature()
        {
            double temperature;
            Console.WriteLine("Do you wish to convert to Celsius or Farenheit? (insert C or F) ");
            
            string type = Console.ReadLine().ToUpper();
         
            while (!type.Equals("C") && !type.Equals("F"))
            {
                Console.WriteLine("Please select C or F");
                type = Console.ReadLine();
            }
                Console.WriteLine("Insert your degrees");
            temperature=Convert.ToDouble(Console.ReadLine());
            
            switch (type)
            {
                case "C":
                    temperature = (temperature * (9.0/5.0)) + 32;
                    break;
                case "F":
                    temperature = (temperature - 32) * (5.0 / 9.0);
                    break;
                default:
                    break;
            }
            return temperature;
        }

    }

    public static class Program3
    {
       public static void checkTriangle()
        {
            double angles;
  
            Console.WriteLine("Please Insert 3 angles : ");
            Console.Write("1st: ");
            angles=Convert.ToDouble(Console.ReadLine());
            Console.Write("2nd: ");
            angles =angles+ Convert.ToDouble(Console.ReadLine());
            Console.Write("3rd: ");
            angles=angles+Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Angles sum: " + angles);
            if (angles == 180)
                Console.WriteLine("The triangle can be made");
            else
            {
                Console.WriteLine("The triangle cannot be made");
                return;
            }
            Console.WriteLine("Please insert 3 sides:  ");
            Console.Write("1st Side:");
            int side1, side2, side3;
            side1 =Convert.ToInt32(Console.ReadLine());
            Console.Write("2nd Side:");
            side2= Convert.ToInt32(Console.ReadLine());
            Console.Write("3rd Side:");
            side3= Convert.ToInt32(Console.ReadLine());

            if (side1 == side2 && side2 == side3)
                Console.WriteLine("The triangle is equilateral");
            else if (side1 == side2 || side2 == side3 || side1 == side3)
                Console.WriteLine("The triangle is isoscel");
            else
                Console.WriteLine("The triangle is scalene");

        }
    }

    class Run
    {
        static void Main(string[] args)
        {
            while (true)
            {
                

                Console.WriteLine("1.Find the surface of a circle");
                Console.WriteLine("2.Convert Celsius degrees to Fahrenheit or vice-versa");
                Console.WriteLine("3.Triangle properties");
                Console.WriteLine("4.Exit the app");
                Console.WriteLine();
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine(Program.surfaceOfCircle());
                        break;
                    case 2:
                        Console.WriteLine(Program2.convertTemperature());
                        break;
                    case 3:
                        Program3.checkTriangle();
                        break;
                    case 4:
                        return;
                        
                }
                Console.WriteLine("Press enter to continue ");
                Console.ReadLine();

                Console.Clear();

            }
            
        }
    }
   
}
