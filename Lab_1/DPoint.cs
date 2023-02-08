using System;
namespace oop3k
{
    public class DPoint
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public DPoint()
        {
            X = 0;
            Y = 0;
        }

        public DPoint(int x, int y)
        {
            X = x;
            Y = y;
        }

        public DPoint(DPoint point)
        {
            X = point.X;
            Y = point.Y;
        }

        public override string ToString()
        {
            return $"[X: {X}. Y: {Y}.]";
        }

        public static implicit operator string(DPoint point)
        {
            return point.ToString();
        }



        public static DPoint operator +(DPoint fPoint, DPoint sPoint) =>
            new DPoint(fPoint.X + sPoint.X, fPoint.Y + sPoint.Y);

        public static DPoint operator -(DPoint fPoint, DPoint sPoint) =>
            new DPoint(fPoint.X - sPoint.X, fPoint.Y - sPoint.Y);

        public static DPoint operator *(DPoint point, int number) =>
            new DPoint(point.X * number, point.Y * number);

        public static bool operator ==(DPoint fPoint, DPoint sPoint)
            => fPoint.X == sPoint.X && fPoint.Y == sPoint.Y;

        public static bool operator !=(DPoint fPoint, DPoint sPoint)
            => fPoint.X != sPoint.X || fPoint.Y != sPoint.Y;
    }
}

