using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class ShapeQuadraticTetrahedron : ShapeFunction
    {
        public ShapeQuadraticTetrahedron()
        {
            Size = 10;
            Dim = 3;
        }

        public ShapeQuadraticTetrahedron(double[,] px)
        {
            Size = 10;
            Dim = 3;
            SetCoord(Size, px);
        }

        protected override double ShapeCoeff(int i, int j)
        {
            double x = X[i, 0];
            double y = X[i, 1];
            double z = X[i, 2];

            switch (j)
            {
                case 0:
                    return 1 - 3 * x - 3 * y - 3 * z + 2 * x * x + 4 * x * y + 4 * y * z + 2 * y * y + 4 * x * z + 2 * z * z;
                case 1:
                    return 4 * x * (1 - x - y - z);
                case 2:
                    return x * (2 * x - 1);
                case 3:
                    return 4 * x * y;
                case 4:
                    return 4 * y * (1 - x - y - z);
                case 5:
                    return y * (2 * y - 1);
                case 6:
                    return 4 * y * z;
                case 7:
                    return 4 * x * z;
                case 8:
                    return 4 * z * (1 - x - y - z);
                case 9:
                    return z * (2 * z - 1);
                default:
                    return 0.0;
            }
        }
    }
}
