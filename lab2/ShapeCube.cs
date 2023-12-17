using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class ShapeCube : ShapeFunction
    {
        public ShapeCube()
        {
            Size = 8;
            Dim = 3;
        }

        public ShapeCube(double[,] px)
        {
            Size = 8;
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
                    return 0.125 * (1 - x) * (1 - y) * (1 - z);
                case 1:
                    return 0.125 * (1 + x) * (1 - y) * (1 - z);
                case 2:
                    return 0.125 * (1 + x) * (1 + y) * (1 - z);
                case 3:
                    return 0.125 * (1 - x) * (1 + y) * (1 - z);
                case 4:
                    return 0.125 * (1 - x) * (1 - y) * (1 + z);
                case 5:
                    return 0.125 * (1 + x) * (1 - y) * (1 + z);
                case 6:
                    return 0.125 * (1 + x) * (1 + y) * (1 + z);
                case 7:
                    return 0.125 * (1 - x) * (1 + y) * (1 + z);
                default:
                    return 0.0;
            }
        }
    }

}
