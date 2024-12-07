using System;
using System.IO;
using System.Linq;

        // File paths for the CSV files
string leftPath = "C:\\HTL\\CABS\\ProtokollAdventOfCode\\LeftList.csv"; 
string rightPath = "C:\\HTL\\CABS\\ProtokollAdventOfCode\\RightList.csv";


int[] leftArray = File.ReadAllLines(leftPath).Select(int.Parse).ToArray();
int[] rightArray = File.ReadAllLines(rightPath).Select(int.Parse).ToArray();

Array.Sort(leftArray);
Array.Sort(rightArray);

Console.WriteLine(string.Join(", ", leftArray));
Console.WriteLine(string.Join(", ", rightArray));