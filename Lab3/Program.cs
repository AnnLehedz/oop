using System;

namespace Lab3
{
    interface ILinearEquations2D
    {
        void Solve(double a1, double b1, double c1, double a2, double b2, double c2);
    }

    interface ILinearEquations3D
    {
        void Solve(double a1, double b1, double c1, double d1, double a2, double b2,
            double c2, double d2, double a3, double b3, double c3, double d3);
    }
    
    class LinearEquations : ILinearEquations2D, ILinearEquations3D
    {
        public void Solve(double a1, double b1, double c1, double a2, double b2, double c2)
        {
            double det = a1 * b2 - a2 * b1;
           
            if (det == 0)
            {
                Console.WriteLine("System has no unique solutions.");
            }
            else
            {
                double x = (b2 * c1 - b1 * c2) / det;
                double y = (a1 * c2 - a2 * c1) / det;
                Console.WriteLine($"x = {x}, y = {y}");
            }
        }

        public void Solve(double a11, double b11, double c11, double d11, double a22,
            double b22, double c22, double d22, double a33, double b33, double c33, double d33)
        {
            double det = a11 * b22 * c33 + b11 * c22 * a33 + c33 * a22 * b33 - c11 * b22 * a33 - a11 * c33 * b33 - b11 * a22 * c33;

            if (det == 0)
            {
                Console.WriteLine("System has no unique solutions.");
            }
            else
            {
                double detX = d11 * b22 * c33 + c11 * b22 * d33 + c11 * d22 * b33 - c11 * b22 * d33 - d11 * c22 * b33 - b11 * d22 * c33;
                double detY = a11 * d22 * c33 + d11 * c22 * a33 + c11 * a22 * d33 - c11 * d22 * a33 - a11 * c22 * d33 - d11 * a22 * c33;
                double detZ = a11 * b22 * d33 + b11 * d22 * a33 + d11 * a22 * b33 - d11 * b22 * a33 - a11 * d22 * b33 - b11 * a22 * d33;

                double x = detX / det;
                double y = detY / det;
                double z = detZ / det;

                Console.WriteLine($"x = {x}, y = {y}, z = {z}");
            }
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("LinearEquations2D");
            ILinearEquations2D system2d = new LinearEquations();
            system2d.Solve(3, 2, 1, 1, 4, -3);
            Console.WriteLine();
            Console.WriteLine("LinearEquations3D");
            ILinearEquations3D system3d = new LinearEquations();
            system3d.Solve(1, 2, 0, 4, 8, 10, 0, 2, 4, 1, 2, 1);

        }
    }
}

