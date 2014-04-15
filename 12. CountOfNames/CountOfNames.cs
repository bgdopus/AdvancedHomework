using System;
using System.Collections.Generic;

class CountOfNames
{
    static void Main()
    {
        //Console.Write("Number of names for first list: ");
        //int n = int.Parse(Console.ReadLine());
        //List<string> names = new List<string>();

        //List<string> names = new List<string>() { "Peter", "Steve", "Nakov", "Steve", "Alex", "Nakov"};
        List<string> names = new List<string>() { "Nakov", "Nakov", "Nakov", "SoftUni ", "Nakov" };
        List<string> copynames = new List<string>(names);

        //Console.WriteLine("Enter {0} names for first list:", n);

        //for (int i = 0; i < n; i++)
        //{
        //    names.Add(Console.ReadLine());
        //}

        names.Sort();
        foreach (var name in names)
        {
            int cnt = 0;
            while (copynames.Contains(name))
            {
                copynames.Remove(name);
                cnt++;
            }

            if (cnt > 0)
            {
                Console.WriteLine(name + " -> " + cnt);
            }

        }


    }
}
