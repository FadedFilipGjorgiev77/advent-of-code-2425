using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

partial class Program
{
    static void Main(string[] args)
    {
        // File paths for the CSV files
        string leftPath = "C:\\HTL\\CABS\\ProtokollAdventOfCode\\LeftList.csv";
        string rightPath = "C:\\HTL\\CABS\\ProtokollAdventOfCode\\RightList.csv";

        int[] leftArray = File.ReadAllLines(leftPath).Select(int.Parse).ToArray();
        int[] rightArray = File.ReadAllLines(rightPath).Select(int.Parse).ToArray();
    }
}