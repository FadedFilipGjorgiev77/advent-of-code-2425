using System;
int smallestNumberLeft = 0;
int smallestNumberRight = 0;
int difference = 0;
int[] list = {2, 3, 4, 5, 6, 7 ,9, 10, 15, 25, 40};
int i = 0;

string leftList = "LeftList.csv";
string rightList = "RightList.csv";

// Read all lines from the file (each line contains a single number)
string[] lines = File.ReadAllLines(filePath);

// Create an array to store the numbers
int[] numbers = new int[lines.Length];

// Convert each line to an integer and store it in the array
for (int i = 0; i < lines.Length; i++)
{
    if (int.TryParse(lines[i], out int number))
    {
        numbers[i] = number;
    }
    else
    {
        Console.WriteLine($"Invalid value: {lines[i]}");
    }
}