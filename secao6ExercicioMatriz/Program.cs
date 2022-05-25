using System;

namespace secao6ExercicioMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            int[,] matrizData = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] rowValues = Console.ReadLine().Split(' ');
                for (int j = 0; j < cols; j++)
                {
                    matrizData[i, j] = int.Parse(rowValues[j]);
                }
            }

            int valueSelected = int.Parse(Console.ReadLine());
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrizData[i, j] == valueSelected)
                    {
                        Console.WriteLine("Position" + i + "," + j + ":");
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + matrizData[i, j - 1]);
                        }
                        if(i > 0)
                        {
                            Console.WriteLine("Up: " + matrizData[i - 1, j]);

                        }
                        if (j < rows - 1)
                        {
                            Console.WriteLine("Right: " + matrizData[i, j + 1]);
                        }
                        if(i < cols - 1)
                        {
                            Console.WriteLine("Down: " + matrizData[i + 1, j]);
                        }

                    }
                }

            }
        }
    }
}
