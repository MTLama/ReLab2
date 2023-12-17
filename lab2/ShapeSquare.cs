using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class ShapeSquare : ShapeFunction
    {
        public ShapeSquare()
        {
            Size = 4;
            Dim = 2;
        }

        public ShapeSquare(double[,] px)
        {
            Size = 4;
            Dim = 2;
            SetCoord(Size, px);
        }

        protected override double ShapeCoeff(int i, int j)
        {
            double[] s = { 1.0, X[i, 0], X[i, 1], X[i, 0] * X[i, 1] };
            return s[j];
        }
    }
}
