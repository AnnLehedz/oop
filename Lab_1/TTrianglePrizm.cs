using System;
namespace oop3k
{
    public class TTrianglePrizm : TTriangle
    {
        public double H { get; set; }

        public TTrianglePrizm()
        {
        }

        public TTrianglePrizm(Side sideAB, Side sideBC, Side sideCD, double h) : base(sideAB, sideBC, sideCD)
        {
            H = h;
        }

        public TTrianglePrizm(TTrianglePrizm triangle) : base(triangle)
        {
            H = triangle.H;
        }

        public TTrianglePrizm(TTriangle triangle, double h) : base(triangle)
        {
            H = h;
        }

        public override double GetSquare()
        {
            double p = ((double)SideAB + (double)SideBC + (double)SideCA) / 2d;
            
            return Math.Sqrt(p * (p - SideAB) * (p - SideBC) * (p - SideCA)) * H;
        }
    }
}

