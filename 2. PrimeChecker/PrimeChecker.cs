using System;

class PrimeChecker
{
    static void Main()
    {

        Console.Write("Enter n = ");
        long n;        
        while (true)
        {
            n = long.Parse((Console.ReadLine()));

            if (n < 0)
            {
                Console.WriteLine("Do enter n bigger than n   ");
                Console.Write("Enter n = ");
            }
            else
            {
                break;
            }
        }
        IsPrime(n);
    }

    static void IsPrime(long n)
    {
        long prime = 1;
        for (long i = 2; i < n; i++)
        {
            if ((n % i) == 0)
            {
                break;
            }
            prime = i;
        }
        prime++;

        if ((prime == n) && ((n % prime) == 0))
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }

}
