using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

partial class Program
{
    static void Main(string[] args)
    {
        // File paths for the CSV files
        string leftPath = "C:\\HTL\\CABS\\ProtokollAdventOfCode\\LeftList.csv";
        string rightPath = "C:\\HTL\\CABS\\ProtokollAdventOfCode\\RightList.csv";
        int sum = 0;

        int[] leftArray = File.ReadAllLines(leftPath).Select(int.Parse).ToArray();
        int[] rightArray = File.ReadAllLines(rightPath).Select(int.Parse).ToArray();

        Dictionary<int, int> frequencyDict = new Dictionary<int, int>();
        foreach (int num in rightArray)
        {
            if (frequencyDict.ContainsKey(num))
            {
                frequencyDict[num]++;
            }
            else
            {
                frequencyDict[num] = 1;
            }
        }

        foreach (int leftNumber in leftArray)
        {
            if (frequencyDict.ContainsKey(leftNumber))
            {
                sum += leftNumber * frequencyDict[leftNumber];
            }
        }
        Console.WriteLine(sum);
    }
}