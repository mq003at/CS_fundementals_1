// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        // Asignment 1
        Console.WriteLine("Assignment 1: ");
        Console.Write("Enter the text to convert into title case: ");
        var inputTitle = Console.ReadLine();

        if (!String.IsNullOrEmpty(inputTitle))
        {
            string[] individualWordsArr = inputTitle.Split(' ');
            string outputTitle = "";

            // Using foreach to get every element, each will have its first letter upper and other will be lower.
            foreach (string word in individualWordsArr)
            {
                outputTitle += char.ToUpper(word[0]) + word.Substring(1).ToLower() + " ";
            }

            Console.WriteLine($"Your title: {outputTitle.Remove(outputTitle.Length - 1)}.");
        }

        // Asignment 2
        Console.WriteLine("\nAssignment 2:");
        Console.Write("Input the number of rows in A matrix: ");
        int aRowLength = int.Parse(Console.ReadLine());
        Console.Write(
            "Input the number of columns in A matrix. It will also be the number of rows in B: "
        );
        int aColumnLength = int.Parse(Console.ReadLine());
        Console.Write("Input the number of columns in B matrix: ");
        int bColumnLength = int.Parse(Console.ReadLine());

        double[,] aMatrix = new double[aRowLength, aColumnLength];
        double[,] bMatrix = new double[aColumnLength, bColumnLength];
        double[,] resultMatrix = new double[aRowLength, bColumnLength];

        // Get input for the 1st matrix
        Console.WriteLine("\nMatrix A: ");
        for (int i = 0; i < aRowLength; i++)
        {
            for (int j = 0; j < aColumnLength; j++)
            {
                int value;
                string input;
                do
                {
                    Console.Write($"Input number at column {j + 1} for row {i + 1}: ");
                    input = Console.ReadLine();
                    if (!int.TryParse(input, out value))
                        Console.WriteLine("Invalid input. Must be a number.");
                    else
                        aMatrix[i, j] = int.Parse(input);
                } while (!int.TryParse(input, out value));
            }
        }

        // Get input for 2nd matrix
        Console.WriteLine("\nMatrix B: ");
        for (int i = 0; i < aColumnLength; i++)
        {
            for (int j = 0; j < bColumnLength; j++)
            {
                int value;
                string input;
                do
                {
                    Console.Write($"Input number at column {j + 1} for row {i + 1}: ");
                    input = Console.ReadLine();
                    if (!int.TryParse(input, out value))
                        Console.WriteLine("Invalid input. Must be a number.");
                    else
                        bMatrix[i, j] = int.Parse(input);
                } while (!int.TryParse(input, out value));
            }
        }

        // Calculate and return result
        for (int i = 0; i < aRowLength; i++)
        {
            for (int j = 0; j < bColumnLength; j++)
            {
                for (int k = 0; k < aColumnLength; k++)
                {
                    resultMatrix[i, j] += aMatrix[i, k] * bMatrix[k, j];
                }
            }
        }

        // Output Matrix A:
        Console.Write("\nYour Matrix A: ");
        for (int i = 0; i < aRowLength; i++)
        {
            Console.Write("{");
            for (int j = 0; j < aColumnLength; j++)
            {
                Console.Write(aMatrix[i, j]);
                if (j != aColumnLength - 1)
                    Console.Write(", ");
            }
            Console.Write("}");
            if (i != aRowLength - 1)
                Console.Write(", ");
            else
                Console.Write(".");
        }

        // Output Matrix A:
        Console.Write("\nYour Matrix B: ");
        for (int i = 0; i < aColumnLength; i++)
        {
            Console.Write("{");
            for (int j = 0; j < bColumnLength; j++)
            {
                Console.Write(bMatrix[i, j]);
                if (j != bColumnLength - 1)
                    Console.Write(", ");
            }
            Console.Write("}");
            if (i != aColumnLength - 1)
                Console.Write(", ");
            else
                Console.Write(".");
        }

        // Output Matrix C:
        Console.Write("\nYour Matrix Result: ");
        for (int i = 0; i < aRowLength; i++)
        {
            Console.Write("{");
            for (int j = 0; j < bColumnLength; j++)
            {
                Console.Write(resultMatrix[i, j]);
                if (j != bColumnLength - 1)
                    Console.Write(", ");
            }
            Console.Write("}");
            if (i != aRowLength - 1)
                Console.Write(", ");
            else
                Console.Write(".");
        }
    }
}
