using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int sum = SumAllElements(input, 0);
        Console.WriteLine(sum);
    }

    private static int SumAllElements(int[] input, int index)
    {
        if (index == input.Length-1)
        {
            return input[index];
        }

        return input[index] + SumAllElements(input, index+1);
    }
}