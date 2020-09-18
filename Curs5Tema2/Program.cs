using System;
using System.Collections.Generic;
using System.Linq;

namespace Curs5Tema2
{
    class Program
    {
        public static void makeLists(int choice)
        {
            List<string> teachers = new List<string>();
            teachers.AddRange(new List<string>() { "John", "Maria", "Philip", "Alicia" });

            List<string> students = new List<string>();
            students.AddRange(new List<string>() { "Julian", "Carter", "Wyatt", "Lily", "Grayson", "Lillian" });

            if (choice == 1) {
                Program.printLists(teachers);
            } else {
                Program.printLists(students);
            }
        }

        static void printLists(List<string> list)
        {
            foreach (string name in list) {
                Console.WriteLine(name);
            }
        }

    }

    class Program2
    {
        public static List<int> checkPrime(int[] array)
        {
            int flag = 0;
            List<int> primeNumbers = new List<int>();
            foreach (int value in array) {
                for (int i = 2; i < value; i++) {
                    if (value % i == 0) {
                        flag = 1;
                        break;
                    } else {
                        flag = 0;
                    }
                }
                if (flag == 0) {
                    primeNumbers.Add(value);
                }
            }
            return primeNumbers;
        }

        public static List<int> checkPrime(List<int> list)
        {
            List<int> primeNumbers = new List<int>();
            int flag = 0;
            foreach (int value in list) {
                for (int i = 2; i < value; i++) {
                    if (value % i == 0) {
                        flag = 1;
                        break;
                    } else {
                        flag = 0;
                    }
                }
                if (flag == 0) {
                    primeNumbers.Add(value);
                }
            }
            return primeNumbers;
        }

        public static List<int> checkPrime(Dictionary<int,int> dictionary)
        {
            List<int> primeNumbers = new List<int>();
            int flag = 0;
            foreach (int value in dictionary.Values) {
                for (int i = 2; i < value; i++) {
                    if (value % i == 0) {
                        flag = 1;
                        break;
                    } else {
                        flag = 0;
                    }
                }
                if (flag == 0) {
                   primeNumbers.Add(value);
                }
            }
            return primeNumbers;
        }

        public static void collectionsOperations()
        {
            int[] array = new int[] { 6, 10, 4, 9, 32, 7, 3, 8 };
            List<int> list = new List<int>();
            list.AddRange(new List<int>() { 6, 10, 4, 9, 32, 7, 3, 8 });
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            dictionary.Add(1, 6);
            dictionary.Add(2, 10);
            dictionary.Add(3, 4);
            dictionary.Add(4, 9);
            dictionary.Add(5, 32);
            dictionary.Add(6, 7);
            dictionary.Add(7, 3);
            dictionary.Add(8, 8);
            int aux = 0;
            foreach (int number in array) {
                if (number > aux) {
                    aux = number;
                }
            }

            Console.WriteLine($"Max for string is {aux}");
            aux = 99;
            foreach (int number in array) {
                if (number < aux) {
                    aux = number;
                }

            }
            Console.WriteLine($"Min for string is {aux}");
            list.Sort();
            Console.WriteLine($"Min for list is {list[0]}");
            Console.WriteLine($"Max for list is {list[list.Count - 1]}");

            foreach (int number in dictionary.Values) {
                if (number < aux) {
                    aux = number;
                }
            }
            Console.WriteLine($"Min for dictionary is {aux}");

            aux = 0;
            foreach (int number in dictionary.Values) {
                if (number > aux) {
                    aux = number;
                }
            }

            Console.WriteLine($"Max for dictionary is {aux}");
            int sum = 0;
            foreach (int number in array) {
                sum += number;
            }

            Console.WriteLine($"Sum for string is {sum} ");
            Console.WriteLine($"Sum for list is {list.Sum()}");
            sum = 0;
            foreach (int number in dictionary.Values) {
                sum += number;
            }
            Console.WriteLine($"Sum for dictionary is {sum}");

            Console.WriteLine($"There are {checkPrime(array).Count} prime numbers in the string");
            
            
            Console.WriteLine($"There are {checkPrime(list).Count} prime numbers in the list");
            
            Console.WriteLine($"There are {checkPrime(dictionary).Count} prime numbers in the dictionary");

            Console.WriteLine($"The average for array is {checkPrime(array).Average()}");

            Console.WriteLine($"The average for list is {checkPrime(list).Average()}");

            Console.WriteLine($"The average for dictionary is {checkPrime(dictionary).Average()}");

            //Start using LINQ

            Console.WriteLine($"Max of array using LINQ {array.Max()}");
            Console.WriteLine($"Min of array using LINQ {array.Min()}");

            Console.WriteLine($"Max of list using LINQ {list.Max()}");
            Console.WriteLine($"Min of list using LINQ {list.Min()}");

            Console.WriteLine($"Max of dictionary using LINQ {dictionary.Values.Max()}");
            Console.WriteLine($"Min of dictionary using LINQ {dictionary.Values.Min()}");

           
            

            int sumLINQ = (from num in array
                                select num).Sum();
            Console.WriteLine($"Sum of array using LINQ {sumLINQ}");
             sumLINQ = (from num in list
                           select num).Sum();

            Console.WriteLine($"Sum of list using LINQ {sumLINQ}");

            sumLINQ = (from num in dictionary.Values
                       select num).Sum();
            Console.WriteLine($"Sum of dictionary using LINQ {sumLINQ}");

            
        }


    }



        class Run
        {
            static void Main(string[] args)
            {
                Console.Write("Input 1 for teachers or 2 for students: ");
                int input = Int32.Parse(Console.ReadLine());
                Program.makeLists(input);
                Program2.collectionsOperations();


            }
        }
    }

