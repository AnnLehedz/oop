using System;
namespace oop3k
{
    public class Side
    {
        public DPoint PointA { get; set; }
        public DPoint PointB { get; set; }

        public Side()
        {
            PointA = new DPoint();
            PointB = new DPoint();
        }

        public Side(DPoint pointA, DPoint pointB)
        {
            PointA = pointA;
            PointB = pointB;
        }

        public Side(Side side)
        {
            PointA = side.PointA;
            PointB = side.PointB;
        }

        public double GetDistance()
        {
            return Math.Round(Math.Sqrt(Math.Pow(PointA.X - PointB.X, 2) + Math.Pow(PointA.Y - PointB.Y, 2)), 2);
        }

        public override string ToString() => GetDistance().ToString();

        public static implicit operator double(Side side) => side.GetDistance();

        public static Side operator +(Side a, Side b) =>
            new Side(a.PointA + b.PointA, a.PointB + b.PointB);

        public static Side operator -(Side a, Side b) =>
           new Side(a.PointA - b.PointA, a.PointB - b.PointB);

        public static Side operator *(Side a, int number) =>
            new Side(a.PointA * number, a.PointB * number);


        public static bool operator ==(Side a, Side b)
            => a.PointA == b.PointA && a.PointB == b.PointB;

        public static bool operator !=(Side a, Side b)
            => a.PointA != b.PointA || a.PointB != b.PointB;
    }
}

