using System;
using static System.Console;

namespace MatrixPuzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Matrix Exercice.");
            
            WriteLine("Enter with a line and column number: obs.: Only integer numbers");
            string[] numbers = ReadLine().Split(' ');
            int line = int.Parse(numbers[0]);
            int column = int.Parse(numbers[1]);

            int[,] matrix = new int[line, column];

            for (int l = 0; l < line; l++)
            {
                numbers = ReadLine().Split(' ');
                for (int c = 0; c < column; c++)
                {
                    matrix[l, c] = int.Parse(numbers[c]);
                }
            }
            
            WriteLine($"Now type a number from the matrix that you just created");
            int numberX = int.Parse(ReadLine());

            for (int l = 0; l < line; l++)
            {
                for (int c = 0; c < column; c++)
                {
                    if (matrix[l, c] == numberX)
                    {
                        WriteLine($"Number {numberX} is at position {l}, {c}: ");

                        if (c > 0)
                        {
                            WriteLine($"Left: {matrix[l, c-1]}");
                        }
                        if (l > 0)
                        {
                            WriteLine($"Up: {matrix[l -1, c]}");
                        }
                        if (c > column -1)
                        {
                            WriteLine($"Right: {matrix[l, c + 1]}");
                        }
                        if (l > line - 1)
                        {
                            WriteLine($"Down: {matrix[l + 1, c]}");
                        }
                    }
                }
            }





















        }
    }
}