using System;
using System.Drawing;

namespace oop3k
{
    public class TTriangle
    {
        public Side SideAB { get; set; }
        public Side SideBC { get; set; }
        public Side SideCA { get; set; }

        public TTriangle()
        {
            SideAB = new Side();
            SideBC = new Side();
            SideCA = new Side();
        }
        public TTriangle(Side sideAB, Side sideBC, Side sideCD)
        {
            SideAB = sideAB;
            SideBC = sideBC;
            SideCA = sideCD;
            if (IsDegenerateTriangle()) throw new Exception("Warning. Triangle is degenerate!");
        }

        public TTriangle(TTriangle triangle)
        {
            SideAB = new Side(triangle.SideAB);
            SideBC = new Side(triangle.SideBC);
            SideCA = new Side(triangle.SideCA);

            if (IsDegenerateTriangle()) throw new Exception("Warning. Triangle is degenerate!");
        }

        public virtual double GetSquare()
        {
            double p = ((double)SideAB + (double)SideBC + (double)SideCA) / 2d;
            return Math.Sqrt(p * (p - SideAB) * (p - SideBC) * (p - SideCA));
        }


        public double GetPerimetr()
        {
            return (double)SideAB + (double)SideBC + (double)SideCA;
        }


        private bool IsDegenerateTriangle()
        {
            return (SideAB.GetDistance() == SideBC.GetDistance() + SideCA.GetDistance()) ||
                (SideBC.GetDistance() == SideAB.GetDistance() + SideCA.GetDistance()) ||
                (SideCA.GetDistance() == SideAB.GetDistance() + SideBC.GetDistance());
        }

        public static TTriangle operator +(TTriangle fTriangle, TTriangle sTriangle)
        {
            return new TTriangle(fTriangle.SideAB + sTriangle.SideAB,
                fTriangle.SideBC + sTriangle.SideBC,
                fTriangle.SideCA + sTriangle.SideCA);
        }

        public static TTriangle operator -(TTriangle fTriangle, TTriangle sTriangle)
        {
            return new TTriangle(fTriangle.SideAB - sTriangle.SideAB,
                fTriangle.SideBC - sTriangle.SideBC,
                fTriangle.SideCA - sTriangle.SideCA);
        }

        public static TTriangle operator *(TTriangle triangle, int number)
        {
            return new TTriangle(triangle.SideAB * number,
                triangle.SideBC * number, triangle.SideCA * number);
        }

        public static bool operator ==(TTriangle fTriangle, TTriangle sTriangle) =>
            fTriangle.SideAB == sTriangle.SideAB &&
            fTriangle.SideBC == sTriangle.SideBC &&
            fTriangle.SideCA == sTriangle.SideCA;

        public static bool operator !=(TTriangle fTriangle, TTriangle sTriangle) =>
            fTriangle.SideAB != sTriangle.SideAB ||
            fTriangle.SideBC != sTriangle.SideBC ||
            fTriangle.SideCA != sTriangle.SideCA;

        public void Show()
        {
            Console.WriteLine($"Side AB: {SideAB}. Side BC: {SideBC}");
            Console.WriteLine($"Side CA: {SideCA}.");
            Console.WriteLine($"Square: {Math.Round(GetSquare(), 2)} / Perimetr: {Math.Round(GetPerimetr(), 2)}");
        }
    }
}

