using System;
using System.Text.RegularExpressions;
class CountingWord
{
    static void Main()
    {
        string word = "SoftUni";//"Hi";
        string pattern = @"[^0-9a-zA-Z]+";// регуларен израз

        //string str = "Hidden networks say “Hi” only to Hitachi devices. Hi, said Matuhi. HI!";
        //string str = "The Software University (SoftUni) trains software engineers, gives them a profession and a job. Visit us at http://softuni.bg. Enjoy the SoftUnification at SoftUni.BG. Contact us.Email: INFO@SOFTUNI.BG. Facebook: https://www.facebook.com/SoftwareUniversity. YouTube: http://www.youtube.com/SoftwareUniversity. Google+: https://plus.google.com/+SoftuniBg/. Twitter: https://twitter.com/softunibg. GitHub: https://github.com/softuni";
        //string str = "Software University";
        //string str = "SoftUni";
        string str = "SoftUni.SoftUni";
        string newstr = Regex.Replace(str, pattern, " ");

        var arr = newstr.Split(' ');

        int cnt = 0;
        foreach (var item in arr)
        {
            if (item.Trim().ToLower() == word.ToLower())
            {
                cnt++;
            }
        }

        Console.WriteLine(cnt);
    }
}
