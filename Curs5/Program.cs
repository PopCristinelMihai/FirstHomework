using System;
using System.Collections.Generic;

namespace Curs5
{
    class Program
    {
        static void identityMatrix(string[] args)
        {
            int[,] matrix = new int[15, 15];
            for (int i = 0; i < 15; i++) {
                for (int j = 0; j < 15; j++) {
                    if (i == j) {
                        matrix[i, j] = 1;
                    } else {
                        matrix[i, j] = 0;
                    }
                }
            }

            //Printing 
            for (int i = 0; i < 15; i++) {
                Console.WriteLine();
                for (int j = 0; j < 15; j++) {
                    Console.Write(" " + matrix[i, j]);
                }
            }
        }
    }

    class Program2
    {
        public static void matrixMultiplier()
        {
            Random random = new Random();
            int[,] matrix = new int[4, 4];
            int[,] matrix2 = new int[4, 4];
            int[,] result = new int[4, 4];
            for (int i = 0; i < 4; i++) {
                for (int j = 0; j < 4; j++) {
                    matrix[i, j] = random.Next(1, 9);
                }
            }
                for (int i = 0; i < 4; i++) {
                    for (int j = 0; j < 4; j++) {
                        matrix2[i, j] = random.Next(1, 9);
                    }
                }

                for (int i = 0; i < 4; i++) {
                    for (int j = 0; j < 4; j++) {
                        for (int k = 0; k < 4; k++) {
                            result[i, j] += matrix[i,k] * matrix2[k,j];
                        }
                    }
                }

            Printing.printMatrix(matrix);
            Printing.printMatrix(matrix2);
            Printing.printMatrix(result);
            Console.WriteLine();
            }
        }

    class Program3
    {
        public static void pickWinner()
        {
            Dictionary<int, string> competitors = new Dictionary<int, string>();
            competitors.Add(1,"Joe");
            competitors.Add(2, "John");
            competitors.Add(3, "Fred");
            competitors.Add(4, "Mary");
            competitors.Add(5, "Lana");
            competitors.Add(6, "William");
            competitors.Add(7, "Jackson");
            competitors.Add(8, "Mason");
            competitors.Add(9, "Evelyn");
            competitors.Add(10, "Ella");
            Random random = new Random();
            Console.WriteLine($"The first 2 competitors are : {competitors[1]} and {competitors[2]}" );
            Console.Write($"And the winer is {competitors[random.Next(1,10)]}");
            Console.WriteLine();
        }
    }

    class Printing
    { 
        public static void printMatrix(int[,] matrix)
        {
            for (int i = 0; i < 4; i++) {
                Console.WriteLine();
                for (int j = 0; j < 4; j++) {
                    Console.Write(" " + matrix[i, j]);
                }
            }
            Console.WriteLine();
        }
    }


    

    class Run
    {
        static void Main(string[] args)
        {
            Program2.matrixMultiplier();
            Program3.pickWinner();
        }
    }
}




