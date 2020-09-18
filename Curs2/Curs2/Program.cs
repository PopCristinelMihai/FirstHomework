using System;
using System.Collections.Generic;

namespace Curs2
{
    class Program
    {
       public static void checkNumbers()
        {
            Console.Write("Input your number: ");
            int number;
            number=Int32.Parse(Console.ReadLine());
            for (int i=0;i<=number;i++){
                if (i % 2 == 0) {
                    Console.WriteLine($"{i} is an even number");
                } else {
                    Console.WriteLine($"{i} is an odd number");
                }
            }

        }
    }

    class Program2
    {
        public static void checkGrades()
        {
            string answer = "Fail";
            Console.Write("Insert your grade from 1-10: ");
            double grade = Double.Parse(Console.ReadLine());
            if (grade >= 5 && grade < 7) { answer = "Average"; } 
            else if (grade >= 7 && grade <= 8) { answer = "Good"; } 
            else if (grade > 8 && grade < 10) { answer = "Very good"; } 
            else if (grade == 10) { answer = "Excellent"; }
            switch (answer)
            {
                case "Fail": 
                    Console.WriteLine("You failed!");
                    break;
                case "Average": 
                    Console.WriteLine("You scored average");
                    break;
                case "Good":
                    Console.WriteLine("You scored good");
                    break;
                case "Very good":
                    Console.WriteLine("You scored very good");
                    break;
                case "Excellent":
                    Console.WriteLine("You scored excellent!");
                    break;
                default:
                    break;
            }   

        }
    }
    class Program3
    {
        public static void countSymbols()
        {
            Console.WriteLine("Input your string");
            string input = Console.ReadLine();
            Console.Write("What do you wish to find in your string? : ");
            char symbol = (char)Console.Read();
            int count = 0;

            //Using for method to count the symbol 
            for (int i = 0; i < input.Length; i++) {
                if (string.Equals(input[i], symbol)) {
                    count++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Using the for method");
            Console.WriteLine($"The symbol {symbol} has been found {count} times ");
            count = 0;

            //Using while method
            int j = 0;
            while (j < input.Length) {
                if (string.Equals(input[j], symbol)) {
                    count++;
                }
                j++;
            }
            Console.WriteLine();
            Console.WriteLine("Using the while method");
            Console.WriteLine($"The symbol {symbol} has been found {count} times ");
            count = 0;
            j = 0;
            //Using do while method
            do { 
                if (string.Equals(input[j], symbol)) {
                    count++;
                }
                j++;
            } while (j<input.Length);
            Console.WriteLine();
            Console.WriteLine("Using the do/while method");
            Console.WriteLine($"The symbol {symbol} has been found {count} times ");

            //Using foreach method
            //List<char> chars= new List<char>();
            count = 0;
            foreach(char match in input) {
                if (symbol == match) {
                    count++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Using the foreach method");
            Console.WriteLine($"The symbol {symbol} has been found {count} times ");
            Console.WriteLine();

        }
    }

    class Program4
    {
        public static void checkPalindrome()
        {
            Console.Write("Insert the word you want to check: ");
            string word = Console.ReadLine();
            int length = word.Length - 1;
            for (int i = 0; i < word.Length / 2; i++) {
                if (word[i] != word[length-i]) {
                    Console.WriteLine("The word is not a palindrome");
                    return;
                }  
                }

            Console.WriteLine("The word is a palindrome"); 
            }
       }
    

    class Run
    {
        static void Main(string[] args)
        {

            while(true) { 
            Console.WriteLine("1.Check the odd and even numbers");
            Console.WriteLine("2.Check your Grade");
            Console.WriteLine("3.Check the number of symbols in a string");
            Console.WriteLine("4.Check wether a word is a palindrome");
            Console.WriteLine("5.Exit the app");

            Console.WriteLine();
            int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice) {
                    case 1:
                        Program.checkNumbers();
                        break;
                    case 2:
                        Program2.checkGrades();
                        break;
                    case 3:
                        Program3.countSymbols();
                        break;
                    case 4:
                        Program4.checkPalindrome();
                        break;
                    case 5:
                        return;
                    default:
                        break;
                }

                Console.ReadLine();
            }
           

        }
    }
}
