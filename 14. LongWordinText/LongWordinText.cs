using System;

class LongWordinText
{
    static void Main()
    {
        //string str = "Welcome to the Software University";
        string str = "The C# Basics course is awesome start in programming with C# and Visual Studio .";
        var arr = str.Split(' ');

        int maxlen = 0;
        string arritem = "";
        foreach (var item in arr)
        {
            if (maxlen < item.Length)
            {
                maxlen = item.Length;
                arritem = item;
            }       
        }
        Console.WriteLine(arritem);

    }
}
