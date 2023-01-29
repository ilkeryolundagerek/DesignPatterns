using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    internal class LiskovSubstution
    {
    }

    //Bad way...
    public class RectangleBad
    {
        public int A { get; set; }
        public int B { get; set; }

        public RectangleBad(int a, int b)
        {
            A = a;
            B = b;
        }
    }

    public class SquareBad : RectangleBad
    {
        public SquareBad(int a) : base(a, a)
        {
        }
    }

    //Good way...
    public class RectangleGood {
        public int A { get; set; }
        public int B { get; set; }

        public RectangleGood(int a, int b)
        {
            A = a;
            B = b;
        }

        public bool IsSquare()
        {
            return A == B;
        }
    }
}
