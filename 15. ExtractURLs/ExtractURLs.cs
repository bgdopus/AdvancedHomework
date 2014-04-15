using System;

class ExtractURLs
{
    static void Main()
    {
        string str = "The site nakov.com can be access from http://nakov.com or www.nakov.com. It has subdomains like mail.nakov.com and svetlin.nakov.com. Please check http://blog.nakov.com for more information";
        var arr = str.Split(' ');

        foreach (var item in arr)
        {
            if (item.Contains("http://") | item.Contains("www."))
            {
                Console.WriteLine(item);
            }
        }

    }
}
