using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    internal class OpenClose
    {
    }


    //BadWay
    public class TriangleBad
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public TriangleBad(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }
    }

    public class CircleBad
    {
        public int r { get; set; }
        public double PI { get; set; }

        public CircleBad(int r, double pi = Math.PI)
        {
            this.r = r;
            PI = pi;
        }
    }

    public class ShapeCalcBad
    {
        public double TrianglePerimeter(TriangleBad triangle)
        {
            return triangle.A + triangle.B + triangle.C;
        }

        public double CirclePerimeter(CircleBad circle)
        {
            return circle.r * circle.PI * 2;
        }
    }

    //Good Way...
    public interface IShapeGood
    {
        double CalculatePerimeter();
    }

    public class TriangleGood : IShapeGood
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public TriangleGood(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double CalculatePerimeter()
        {
            return A + B + C;
        }
    }

    public class CircleGood : IShapeGood
    {
        public int r { get; set; }
        public double PI { get; set; }

        public CircleGood(int r, double pi = Math.PI)
        {
            this.r = r;
            PI = pi;
        }

        public double CalculatePerimeter()
        {
            return 2 * r * PI;
        }
    }


    public class ShapeCalcGood
    {
        public double CalculatePerimeter(IShapeGood shape)
        {
            return shape.CalculatePerimeter();
        }
    }
}
