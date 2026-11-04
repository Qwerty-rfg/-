using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[,] num = new int[,]{
            {1, 2, 3},
            {4, 4, 5},
            {6, 7, 8}
        };
        int numRows = num.GetLength(0);
        int numCols = num.GetLength(1);
        var result = new List<int[]>();

        for (int i = 0; i < numRows; i++)
        {
            int[] row = new int[numCols];

            for (int j = 0; j < numCols; j++)
            {
                row[j] = num[i, j];
            }

            Array.Sort(row);
            bool duplicates = false;

            for (int j = 1; j < numCols; j++)
            {
                if (row[j] == row[j - 1])
                {
                    duplicates = true;
                    break;
                }
            }

            if (duplicates)
            {
                result.Add(row);
            }
        }

        int[,] num1 = new int[result.Count, numCols];

        for (int i = 0; i < result.Count; i++)
        {
            for (int j = 0; j < numCols; j++)
            {
                num1[i, j] = result[i][j];
            }
        }

        if (result.Count == 0)
{
    Console.WriteLine("Строк с повторяющимися элементами не найдено.");
}
else
{
    Console.WriteLine("Отфильтрованный массив:");
}

       if (result.Count > 0)
{
    for (int i = 0; i < num1.GetLength(0); i++)
    {
        for (int j = 0; j < num1.GetLength(1); j++)
        {
            Console.Write(num1[i, j] + " ");
        }
        Console.WriteLine();
    }
} 
    }}
