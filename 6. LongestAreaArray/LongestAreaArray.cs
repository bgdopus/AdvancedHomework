using System;
using System.Collections.Generic;

class LongestAreaArray
{
    static void Main()
    {
        /* Само примера:
          
          input             output
            2                 1
            SoftUni         SoftUni
            Hello
         
         не ми се получи и неразбрах защо :) 
      */

        Console.Write("Entert n strings  = ");
        int n = int.Parse(Console.ReadLine());
        List<string> strlist = new List<string>();

        Console.WriteLine("Enter {0} strings:", n);
        for (int i = 0; i < n; i++)
        {
            strlist.Add(Console.ReadLine());
        }
        //List<string> strlist = new List<string>() { "hi",  "ok","hi", "hello", "ok", "ok" };
        //List<string> strlist = new List<string>() { "SoftUni", "Hello" };
        //List<string> strlist = new List<string>() { "hi", "hi", "hi", "hi" };
        //List<string> strlist = new List<string>() { "wow","hi", "hi", "ok", "ok" };
        strlist.Sort();
        int cnt = 0;
        int maxcnt = 0;
        string maxstr = "";
        string newstr = "";
        
        foreach (var str in strlist)
        {
            if (newstr != str)
            {
                newstr = str;
                cnt = 1;
                //maxcnt = cnt;
            }
            else
            {
                cnt++;
                //maxcnt = cnt;
            }

            if (cnt > maxcnt)
            {
                maxcnt = cnt;
                maxstr = str;
            }

        }
        Console.WriteLine();
        Console.WriteLine(maxcnt);
        for (int i = 0; i < maxcnt; i++)
        {
            Console.WriteLine(maxstr);
        }
    }
}
