using System;
using System.IO;
using System.Linq;

        // File paths for the CSV files
string leftPath = "C:\\HTL\\CABS\\ProtokollAdventOfCode\\LeftList.csv"; 
string rightPath = "C:\\HTL\\CABS\\ProtokollAdventOfCode\\RightList.csv";
int difference = 0;

int[] leftArray = File.ReadAllLines(leftPath).Select(int.Parse).ToArray();
int[] rightArray = File.ReadAllLines(rightPath).Select(int.Parse).ToArray();

Array.Sort(leftArray);
Array.Sort(rightArray);

for (int i = 0; i < leftArray.Length; i++)
{
    difference += Math.Abs(leftArray[i] - rightArray[i]);
}

Console.WriteLine(difference);