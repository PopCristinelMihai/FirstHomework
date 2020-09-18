using System;
using System.IO;

namespace Curs3
{
    public class WrongDateFormatExpection : ApplicationException
    {
        public WrongDateFormatExpection(string message) : base (message) { 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string date;
            while (true) {
                Console.WriteLine("Insert the day number (1-366)");
                int number = Int32.Parse(Console.ReadLine());
                if (number < 1 || number > 366) {
                    throw new WrongDateFormatExpection("The day number cannot be under 1 or over 366");
                }
                Console.ReadLine();
                Console.Write(186/30 +1+ "   Month  " + (Math.IEEERemainder(186,30)) + "  Day  ");

                if (number >= 1 && number <= 31) {
                    date = "January " + number;
                    Console.WriteLine(date);
                }
                if (number >= 32 && number <= 59) {
                    date = "February " + number % 31;
                    Console.WriteLine(date);
                }
                if (number >= 60 && number <= 90) {
                    date = "March " + number % 59;
                    Console.WriteLine(date);
                }
                if (number >= 91 && number <= 120) {
                    date = "April" + number;
                    Console.WriteLine(date);
                }
                if (number >= 121 && number <= 151) {
                    date = "May" + number;
                    Console.WriteLine(date);
                }
                if (number >= 152 && number <= 181) {
                    date = "June" + number;
                    Console.WriteLine(date);
                }
                if (number >= 182 && number <= 211) {
                    date = "July " + number%181;
                    Console.WriteLine(date);
                }
                if (number >= 212 && number <= 242) {
                    date = "August" + number;
                    Console.WriteLine(date);
                }
                if (number >= 243 && number <= 243) {
                    date = "September" + number;
                    Console.WriteLine(date);
                }
                if (number >= 242 && number <= 273) {
                    date = "October" + number;
                    Console.WriteLine(date);
                }
                if (number >= 274 && number <= 305) {
                    date = "November" + number;
                    Console.WriteLine(date);
                }
                if (number >= 306 && number <= 336) {
                    date = "December" + number;
                    Console.WriteLine(date);

                }
            }
            Console.ReadLine();
            
        }
    }
}
