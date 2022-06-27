using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int findFactoriel = Factoriel(n);

        Console.WriteLine(findFactoriel);
    }

    private static int Factoriel(int factoriel)
    {
        if (factoriel == 1)
        {
            return 1;
        }

        return factoriel = factoriel * Factoriel(factoriel - 1);
    }
}