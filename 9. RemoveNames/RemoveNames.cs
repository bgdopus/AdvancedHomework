using System;
using System.Collections.Generic;

class RemoveNames
{
    static void Main()
    {


        Console.Write("Number of names for first list: ");
        int n = int.Parse(Console.ReadLine());
        List<string> firstlist = new List<string>();
        List<string> secondlist = new List<string>();

        //List<string> firstlist = new List<string>() { "Peter", "Alex", "Maria", "Todor", "Steve" ,"Diana", "Steve"};
        //List<string> secondlist = new List<string>() { "Todor", "Steve", "Nakov"};

        //List<string> firstlist = new List<string>() { "Hristo ", "Hristo", "Nakov", "Nakov", "Petya",  };
        //List<string> secondlist = new List<string>() { "Nakov", "Vanessa", "Maria" };

        Console.WriteLine("Enter {0} names for first list:", n);

        for (int i = 0; i < n; i++)
        {
            firstlist.Add(Console.ReadLine());
        }

        Console.Write("Number of names for second list: ");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter {0} names for second list:", n);
        for (int i = 0; i < n; i++)
        {
            secondlist.Add(Console.ReadLine());
        }

        foreach (var names in secondlist)
        {
            do
            {
                firstlist.Remove(names);
            } while (firstlist.Contains(names));
        }

        Console.WriteLine();
        foreach (var item in firstlist)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();
    }


}
