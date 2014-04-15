using System;
using System.Collections.Generic;
class JoinLists
{
    static void Main()
    {
        Console.Write("Number of integers for first list: ");
        int n = int.Parse(Console.ReadLine());
        List<int> firstlist = new List<int>();
        List<int> secondlist = new List<int>();

        //List<int> firstlist = new List<int>() { 20, 40, 10, 10, 30, 80 };
        //List<int> secondlist = new List<int>() { 25, 20, 40, 30, 10 };

        //List<int> firstlist = new List<int>() { 5, 4, 3, 2, 1 };
        //List<int> secondlist = new List<int>() { 6, 3, 2 };

        //List<int> firstlist = new List<int>() { 1};
        //List<int> secondlist = new List<int>() { 1};

        Console.WriteLine("Enter {0} integers for first list:", n);

        for (int i = 0; i < n; i++)
        {
            firstlist.Add(int.Parse(Console.ReadLine()));
        }

        Console.Write("Number of integers for second list: ");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter {0} integers for second list:", n);
        for (int i = 0; i < n; i++)
        {
            secondlist.Add(int.Parse(Console.ReadLine()));
        }

        foreach (var integers in secondlist)
        {
            do
            {
                firstlist.Remove(integers);
            } while (firstlist.Contains(integers));

            if (!firstlist.Contains(integers))
            {
                firstlist.Add(integers);
            }
        }

        firstlist.Sort();

        Console.WriteLine();

        foreach (var item in firstlist)
        {
            Console.WriteLine(item);
        }
    }
}
