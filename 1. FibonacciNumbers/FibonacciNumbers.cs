using System;
class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Entert n = ");
        int n = int.Parse(Console.ReadLine());
        
        FibCalc(n);
    }

    static void FibCalc(int n)
    {
        long fib = 1;

        for (int i = 1; i <= n; i++)
        {
            fib = fib * i;
        }

        Console.WriteLine("The fibonachi number of {0} is {1} !", n, fib);
    }
}
