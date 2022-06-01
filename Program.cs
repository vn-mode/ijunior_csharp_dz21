using System;

namespace vn_mode_csharp_dz21
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[10, 10];
            int minNumberForRandom = 1;
            int maxNumberForRandom = 10;
            int maxNumberInMatrix = int.MinValue;
            int numberForReplace = 0;
            Random random = new Random();
            Console.WriteLine("Исходная матрица:\n");

            for (int i = 0; i< matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(minNumberForRandom, maxNumberForRandom);
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }

            foreach (var number in matrix)
            {
                if (maxNumberInMatrix < number)
                {
                    maxNumberInMatrix = number;
                }
            }
            Console.WriteLine($"\nМаксимальное число в исходной матрице = {maxNumberInMatrix}");
            Console.WriteLine("\nИзменённая матрица:");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(matrix[i,j] == maxNumberInMatrix)
                    {
                        matrix[i, j] = numberForReplace;
                    }
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
