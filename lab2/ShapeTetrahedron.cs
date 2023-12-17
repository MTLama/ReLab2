using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class ShapeTetrahedron : ShapeFunction
    {
        public ShapeTetrahedron()
        {
            Size = 4;
            Dim = 3;
        }

        public ShapeTetrahedron(double[,] px)
        {
            Size = 4;
            Dim = 3;
            SetCoord(Size, px);
        }

        protected override double ShapeCoeff(int i, int j)
        {
            double[] s = { 1.0, X[i, 0], X[i, 1], X[i, 2] };
            return s[j];
        }
    }
}
