using System;
using System.Collections.Generic;


class SortingNumbers
{
    static void Main()
    {
        Console.Write("Entert n  = ");
        int n = int.Parse(Console.ReadLine());
        List<int> nlist = new List<int>();


        Console.WriteLine("Enter {0} numbers:", n);
        for (int i = 0; i < n; i++)
        {
            nlist.Add(int.Parse(Console.ReadLine()));
        }
        nlist.Sort();

        foreach (var num in nlist)
        {
            Console.WriteLine(num);
        }

    }
}
