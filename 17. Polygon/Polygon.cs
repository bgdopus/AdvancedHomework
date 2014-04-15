using System;

class Polygon
{
    static void Main()
    {
        int n = 3;
        int[] xPts = new int[3] { 0, 0, 1 };
        int[] yPts = new int[3] { 0, 1, 1 };

        //int n = 7;
        //int[] xPts = new int[7] { -2, 1, 5, 1, 1, 3, -2 };
        //int[] yPts = new int[7] { 1, 3, 1, 2, 1, -2, 1 };
        polygonArea(xPts, yPts, n);
    }

    static void polygonArea(int[] xPts, int[] yPts, int n)
    {
        double area = 0;
        double primeter = 0;

        int j = n - 1;

        for (int i = 0; i < n; i++)
        {
            area = area + (xPts[j] + xPts[i]) * (yPts[j] - yPts[i]);
            j = i; 
        }

        j = n-1;
        for (int i = 0; i < n-1; i++)
        {   

           primeter = primeter +  Math.Sqrt((xPts[j] - xPts[i]) * (xPts[j] - xPts[i]) + (yPts[j] + yPts[i]) * (yPts[j] + yPts[i]));
           j = i;     
        }
        Console.WriteLine("primeter = {0:F2}" , primeter);
        Console.WriteLine("area = {0:F2} ",area / 2);
    }
}
