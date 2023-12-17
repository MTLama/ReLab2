using System;

namespace lab2
{
    //class ShapeTriangle : ShapeFunction
    //{
    //    public ShapeTriangle()
    //    {
    //        Size = 3;
    //        Dim = 2;
    //    }
    //    public ShapeTriangle(double[,] px)
    //    {
    //        Size = 3;
    //        Dim = 2;
    //        SetCoord(Size, px);
    //    }
    //    protected override double ShapeCoeff(int i, int j)
    //    {
    //        double[] s = { 1.0, X[i, 0], X[i, 1] };
    //        return s[j];
    //    }
    //}



    //class ShapeSquare : ShapeFunction
    //{
    //    public ShapeSquare()
    //    {
    //        Size = 4;
    //        Dim = 2;
    //    }

    //    public ShapeSquare(double[,] px)
    //    {
    //        Size = 4;
    //        Dim = 2;
    //        SetCoord(Size, px);
    //    }

    //    protected override double ShapeCoeff(int i, int j)
    //    {
    //        double[] s = { 1.0, X[i, 0], X[i, 1], X[i, 0] * X[i, 1] };
    //        return s[j];
    //    }
    //}



    //class ShapeTetrahedron : ShapeFunction
    //{
    //    public ShapeTetrahedron()
    //    {
    //        Size = 4;
    //        Dim = 3;
    //    }

    //    public ShapeTetrahedron(double[,] px)
    //    {
    //        Size = 4;
    //        Dim = 3;
    //        SetCoord(Size, px);
    //    }

    //    protected override double ShapeCoeff(int i, int j)
    //    {
    //        double[] s = { 1.0, X[i, 0], X[i, 1], X[i, 2] };
    //        return s[j];
    //    }
    //}



    //class ShapeCube : ShapeFunction
    //{
    //    public ShapeCube()
    //    {
    //        Size = 8;
    //        Dim = 3;
    //    }

    //    public ShapeCube(double[,] px)
    //    {
    //        Size = 8;
    //        Dim = 3;
    //        SetCoord(Size, px);
    //    }

    //    protected override double ShapeCoeff(int i, int j)
    //    {
    //        double x = X[i, 0];
    //        double y = X[i, 1];
    //        double z = X[i, 2];

    //        switch (j)
    //        {
    //            case 0:
    //                return 0.125 * (1 - x) * (1 - y) * (1 - z);
    //            case 1:
    //                return 0.125 * (1 + x) * (1 - y) * (1 - z);
    //            case 2:
    //                return 0.125 * (1 + x) * (1 + y) * (1 - z);
    //            case 3:
    //                return 0.125 * (1 - x) * (1 + y) * (1 - z);
    //            case 4:
    //                return 0.125 * (1 - x) * (1 - y) * (1 + z);
    //            case 5:
    //                return 0.125 * (1 + x) * (1 - y) * (1 + z);
    //            case 6:
    //                return 0.125 * (1 + x) * (1 + y) * (1 + z);
    //            case 7:
    //                return 0.125 * (1 - x) * (1 + y) * (1 + z);
    //            default:
    //                return 0.0;
    //        }
    //    }
    //}




    //class ShapeQuadraticTriangle : ShapeFunction
    //{
    //    public ShapeQuadraticTriangle()
    //    {
    //        Size = 6;
    //        Dim = 2;
    //    }

    //    public ShapeQuadraticTriangle(double[,] px)
    //    {
    //        Size = 6;
    //        Dim = 2;
    //        SetCoord(Size, px);
    //    }

    //    protected override double ShapeCoeff(int i, int j)
    //    {
    //        double x = X[i, 0];
    //        double y = X[i, 1];

    //        switch (j)
    //        {
    //            case 0:
    //                return 1 - 3 * x - 3 * y + 2 * x * x + 4 * x * y + 2 * y * y;
    //            case 1:
    //                return 4 * x * (1 - x - y);
    //            case 2:
    //                return x * (2 * x - 1);
    //            case 3:
    //                return 4 * x * y;
    //            case 4:
    //                return 4 * y * (1 - x - y);
    //            case 5:
    //                return y * (2 * y - 1);
    //            default:
    //                return 0.0;
    //        }
    //    }
    //}



    //class ShapeQuadraticTetrahedron : ShapeFunction
    //{
    //    public ShapeQuadraticTetrahedron()
    //    {
    //        Size = 10;
    //        Dim = 3;
    //    }

    //    public ShapeQuadraticTetrahedron(double[,] px)
    //    {
    //        Size = 10;
    //        Dim = 3;
    //        SetCoord(Size, px);
    //    }

    //    protected override double ShapeCoeff(int i, int j)
    //    {
    //        double x = X[i, 0];
    //        double y = X[i, 1];
    //        double z = X[i, 2];

    //        switch (j)
    //        {
    //            case 0:
    //                return 1 - 3 * x - 3 * y - 3 * z + 2 * x * x + 4 * x * y + 4 * y * z + 2 * y * y + 4 * x * z + 2 * z * z;
    //            case 1:
    //                return 4 * x * (1 - x - y - z);
    //            case 2:
    //                return x * (2 * x - 1);
    //            case 3:
    //                return 4 * x * y;
    //            case 4:
    //                return 4 * y * (1 - x - y - z);
    //            case 5:
    //                return y * (2 * y - 1);
    //            case 6:
    //                return 4 * y * z;
    //            case 7:
    //                return 4 * x * z;
    //            case 8:
    //                return 4 * z * (1 - x - y - z);
    //            case 9:
    //                return z * (2 * z - 1);
    //            default:
    //                return 0.0;
    //        }
    //    }
    //}

    class ShapeException : Exception
    {
        public ShapeException(string message) : base(message)
        {
        }
    }




    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                double[,] triangleCoordinates = { { 0, 0 }, { 1, 0 }, { 1, 1 } }; // Координати вершин СЕ
            ShapeTriangle ShapeTriangle = new ShapeTriangle(triangleCoordinates);
                ShapeTriangle.Print();
            }
            catch (ShapeException ex)
            {
                Console.WriteLine($"ShapeException: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }




            try
            {
                double[,] tetrahedronQuadricCoordinates = {
    {0.0, 0.0, 0.0},
    {1.0, 0.0, 0.0},
    {0.0, 1.0, 0.0},
    {0.0, 0.0, 1.0},
    {0.5, 0.0, 0.0},
    {0.5, 0.5, 0.0},
    {0.0, 0.5, 0.0},
    {0.5, 0.0, 0.5},
    {0.0, 0.5, 0.5},
    {0.5, 0.5, 0.5}
};
            ShapeQuadraticTetrahedron ShapeQuadraticTetrahedron = new ShapeQuadraticTetrahedron(tetrahedronQuadricCoordinates);
            ShapeQuadraticTetrahedron.Print();
            }
            catch (ShapeException ex)
            {
                Console.WriteLine($"ShapeException: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }



            try
                {
                    double[,] quadraticTriangleCoordinates = {
    {0.0, 0.0},
    {1.0, 0.0},
    {0.0, 1.0},
    {0.5, 0.0},
    {0.5, 0.5},
    {0.0, 0.5}
};
            ShapeQuadraticTriangle ShapeQuadraticTriangle = new ShapeQuadraticTriangle(quadraticTriangleCoordinates);
            ShapeQuadraticTriangle.Print();
                }
                catch (ShapeException ex)
                {
                    Console.WriteLine($"ShapeException: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                }



                try
                    {
                        double[,] cubeCoordinates = {
    {0.0, 0.0, 0.0},
    {1.0, 0.0, 0.0},
    {1.0, 1.0, 0.0},
    {0.0, 1.0, 0.0},
    {0.0, 0.0, 1.0},
    {1.0, 0.0, 1.0},
    {1.0, 1.0, 1.0},
    {0.0, 1.0, 1.0}
};
            ShapeCube ShapeCube = new ShapeCube(cubeCoordinates);
            ShapeCube.Print();
                    }
                    catch (ShapeException ex)
                    {
                        Console.WriteLine($"ShapeException: {ex.Message}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                    }


                    try
                        {
                            double[,] tetrahedronCoordinates = {
    {0.0, 0.0, 0.0},
    {1.0, 0.0, 0.0},
    {0.0, 1.0, 0.0},
    {0.0, 0.0, 1.0}
};
            ShapeTetrahedron ShapeTetrahedron = new ShapeTetrahedron(tetrahedronCoordinates);
            ShapeTetrahedron.Print();
                        }
                        catch (ShapeException ex)
                        {
                            Console.WriteLine($"ShapeException: {ex.Message}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                        }


                        try
                            {
                                double[,] squareCoordinates = {
    {0.0, 0.0},
    {1.0, 0.0},
    {1.0, 1.0},
    {0.0, 1.0}
};
            ShapeSquare ShapeSquare = new ShapeSquare(squareCoordinates);
            ShapeSquare.Print();
                            }
                            catch (ShapeException ex)
                            {
                                Console.WriteLine($"ShapeException: {ex.Message}");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                            }

                        }
    }
}