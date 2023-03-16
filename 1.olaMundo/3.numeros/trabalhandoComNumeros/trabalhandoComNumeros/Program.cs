using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int a = 7;
        int b = 4;
        int c = 3;
        int d = (a + b) / c;
        int e = (a + b) % c;

        Console.WriteLine(d);
        Console.WriteLine($"O resto da operação é: {e}");
    }
}

