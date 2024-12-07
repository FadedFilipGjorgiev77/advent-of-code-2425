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
        for (int i = 0; i < rightArray.Length; i++)
        {
            if (frequencyDict.ContainsKey(rightArray[i]))
            {
                frequencyDict[rightArray[i]]++;
            }
            else
            {
                frequencyDict[rightArray[i]] = 1;
            }
        }

        for (int i = 0; i < leftArray.Length; i++)
        {
            int leftNumber = leftArray[i];
            if (frequencyDict.ContainsKey(leftNumber))
            {
                sum += leftNumber * frequencyDict[leftNumber];
            }
        }
    }
}