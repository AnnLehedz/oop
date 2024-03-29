﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab_2._0
{
    public static class ArraysObject
    {

        public static int GetMinValue(int[] array)
        {
            if (array.Length == 0) throw new ArgumentException("Array is empty!");

            int minValue = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (minValue > array[i]) minValue = array[i];
            }

            return minValue;
        }


        public static double[] GetVectorProduct(double[] fVector, double[] sVector)
        {
            if (fVector.Length != sVector.Length) throw new ArgumentException("Incorrect vectors size!");

            double[] product = new double[fVector.Length];
            for (int i = 0; i < product.Length; i++)
            {
                int fIndex = (i + 1) % 3;
                int sIndex = (i + 2) % 3;

                product[i] = fVector[fIndex] * sVector[sIndex] - fVector[sIndex] * sVector[fIndex];
            }

            return product;
        }

        public static double[] GetCompressArray(double[] array)
        {
            double[] compressedArray = new double[array.Length];
            int index = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) >= 1) compressedArray[index++] = array[i];
            }

            return compressedArray;
        }

        public static int[,] SortOddColumnsAsc(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i += 2)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(1); k++)
                    {
                        if (array[i, j] < array[i, k])
                        {
                            int temp = array[i, j];
                            array[i, j] = array[i, k];
                            array[i, k] = temp;
                        }
                    }
                }
            }

            return array;
        }

        public static int GetProductOfRowsWithoutNegative(int[,] matrix)
        {
            int product = 1;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                bool isNegative = false;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        isNegative = true;
                        break;
                    }
                }

                if (!isNegative)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        product *= matrix[i, j];
                    }
                }
            }

            return product;
        }

        public static int GetMaxParallelDiagSum(int[,] matrix)
        {
            int max = int.MinValue;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int fSum = 0, sSum = 0;

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i + j < matrix.GetLength(0))
                    {
                        fSum += matrix[i + j, j];
                        sSum += matrix[j, i + j];
                    }
                }

                max = Math.Max(Math.Max(max, fSum), sSum);
            }

            return max;
        }

    }
}
