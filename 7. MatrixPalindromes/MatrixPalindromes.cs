using System;

class MatrixPalindromes
{
    static void Main()
    {

        Console.Write("Enter rows = ");
        int r = int.Parse(Console.ReadLine());
        Console.Write("Enter columns = ");
        int c = int.Parse(Console.ReadLine());

        //int r = 3;
        //int c = 6;
        string[,] mat = new string[r, c];

        for (int rows = 0; rows < r; rows++)
        {
            for (int col = 0; col < c; col++)
            {
                if (col == 0)
                {
                    mat[rows, col] = Convert.ToChar(97 + rows).ToString() + Convert.ToChar(97 + rows).ToString() + Convert.ToChar(97 + rows).ToString();
                }
                else
                {
                    mat[rows, col] = Convert.ToChar(97 + rows).ToString() + Convert.ToChar(97 + rows + col).ToString() + Convert.ToChar(97 + rows).ToString();
                }
            }
        }

        Console.WriteLine();
        for (int row = 0; row < r; row++)
        {
            for (int col = 0; col < c; col++)
            {
                Console.Write(mat[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}
