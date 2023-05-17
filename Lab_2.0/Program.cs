using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2._0
{
    internal class Program
    {
        public static void ShowArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        public static void ShowArray(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        public static void ShowArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void ShowArray(double[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Random random = new Random();
            int size = 10;
            int vSize = 3;

            int[] array = new int[size];
            double[] fVector = new double[vSize];
            double[] sVector = new double[vSize];
            double[] dArray = new double[size];

            int[,] array2D = new int[size, size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-10, 100);
                dArray[i] = random.Next(0, 3);
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    array2D[i, j] = random.Next(0, 100);
                }
            }
            for (int i = 0; i < vSize; i++)
            {
                fVector[i] = random.Next(0, 10);
                sVector[i] = random.Next(0, 10);
            }
            //1.1
            Console.WriteLine("Array: ");
            ShowArray(array);
            Console.WriteLine("Min value from this array: " + ArraysObject.GetMinValue(array) + ".\n\n");

            //1.2
            Console.WriteLine("First vector: ");
            ShowArray(fVector);
            Console.WriteLine("\nSecond vector: ");
            ShowArray(sVector);
            Console.WriteLine("\nVector cross product: ");
            ShowArray(ArraysObject.GetVectorProduct(fVector, sVector));
            Console.WriteLine("\n\n");

            //1.3
            Console.WriteLine("Array:");
            ShowArray(dArray);
            Console.WriteLine("\nCompress array:");
            ShowArray(ArraysObject.GetCompressArray(dArray));
            Console.WriteLine("\n\n");


            //2.1
            Console.WriteLine("2d Array:\n");
            ShowArray(array2D);
            Console.WriteLine("\nArray after sort columns asc:\n");
            ShowArray(ArraysObject.SortOddColumnsAsc(array2D));
            Console.WriteLine("\n\n");


            //2.2
            int[,] matrix = { { 1, 4, -5 }, { 1, 2, 3 }, { -1, 2, 7 } };

            Console.WriteLine("Matrix:\n");
            ShowArray(matrix);
            Console.WriteLine("\nGet products of row: " + ArraysObject.GetProductOfRowsWithoutNegative(matrix) + ".\n\n");


            //2.3
            Console.WriteLine("Matrix:\n");
            ShowArray(array2D);
            Console.WriteLine("Get max parallel sum of diag: " + ArraysObject.GetMaxParallelDiagSum(array2D) + ".");

        }
    }
}
