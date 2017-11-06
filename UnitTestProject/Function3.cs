﻿using System;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;
using NonLinearEquationsSolver;

namespace UnitTestProject
{
    public class Function3 : IFunction
    {
        public Matrix<double> GetTangentMatrix(Vector<double> u)
        {
            double x = u[0];
            double y = u[1];
            return new DenseMatrix(2, 2)
            {
                [0, 0] = 2 * x,
                [0, 1] = 1,
                [1, 0] = 1,
                [1, 1] = 2 * y,
            };
        }

        public Vector<double> GetImage(Vector<double> u)
        {
            double x = u[0];
            double y = u[1];
            return new DenseVector(2)
            {
                [0] = Math.Pow(x, 2) + y,
                [1] = Math.Pow(y, 2) + y
            };
        }
    }
}