using System;
using System.Collections.Generic;

class PrimesInRange
{
    static void Main()
    {
        Console.Write("Entert startnum = ");
        int startnum = int.Parse(Console.ReadLine());

        Console.Write("Entert endnum = ");
        int endnum = int.Parse(Console.ReadLine());

        //int startnum = 0;
        //int endnum = 5;

        FindPrimesInRange(startnum, endnum);
        Console.WriteLine();
    }

    static void FindPrimesInRange(int startnum, int endnum)
    {
        List <long> primelist = new List <long>();
        for (long i = startnum; i <= endnum; i++)
        {
            if (IsPrime(i) != 0)
            {
                primelist.Add(IsPrime(i));        
            }
        
        }

        int capacity = primelist.Count;
        int j = 1;
        foreach (var prime in primelist)
        {
            if (capacity == j)
            {
                Console.Write(prime);
            }
            else
            {
                Console.Write(prime + ", ");          
            }
            
            j++;
        }
    }

    static long IsPrime(long n)
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
            return prime;
        } else
	    {
            return 0;        
	    }

    }

}



