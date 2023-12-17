using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
   
        class ShapeQuadraticTriangle : ShapeFunction
        {
            public ShapeQuadraticTriangle()
            {
                Size = 6;
                Dim = 2;
            }

            public ShapeQuadraticTriangle(double[,] px)
            {
                Size = 6;
                Dim = 2;
                SetCoord(Size, px);
            }

            protected override double ShapeCoeff(int i, int j)
            {
                double x = X[i, 0];
                double y = X[i, 1];

                switch (j)
                {
                    case 0:
                        return 1 - 3 * x - 3 * y + 2 * x * x + 4 * x * y + 2 * y * y;
                    case 1:
                        return 4 * x * (1 - x - y);
                    case 2:
                        return x * (2 * x - 1);
                    case 3:
                        return 4 * x * y;
                    case 4:
                        return 4 * y * (1 - x - y);
                    case 5:
                        return y * (2 * y - 1);
                    default:
                        return 0.0;
                }
            }
        }
    }

