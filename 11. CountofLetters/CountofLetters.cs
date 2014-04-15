using System;
using System.Collections.Generic;

class CountofLetters
{
    static void Main()
    {
        //Console.Write("Number of letters for first list: ");
        //int n = int.Parse(Console.ReadLine());
        //List<string> letters = new List<string>();

        //List<string> letters = new List<string>() { "b", "b", "a", "a", "b"};
        List<string> letters = new List<string>() { "h", "d" ,"h", "a", "a" ,"a", "s" ,"d" ,"f", "d", "a" ,"d" ,"j" ,"d" ,"s" ,"h" ,"a", "a"};
        List<string> copyletters = new List<string>(letters);
        //List<Int32> copy = new List<Int32>(original);
        //List<string> firstlist = new List<string>() { "Hristo ", "Hristo", "Nakov", "Nakov", "Petya",  };
        //Console.WriteLine("Enter {0} letters for letters list:", n);
        //for (int i = 0; i < n; i++)
        //{
        //    letters.Add(Console.ReadLine());
        //}

        letters.Sort();
        foreach (var lett in letters)
        {
            int cnt = 0;
            while (copyletters.Contains(lett))
            {
                copyletters.Remove(lett);
                cnt++;
            }

            if (cnt > 0)
            {
                Console.WriteLine(lett + " -> " + cnt);    
            }
            
        }

        

    }
}
