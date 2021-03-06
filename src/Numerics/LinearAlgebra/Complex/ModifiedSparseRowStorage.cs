﻿
namespace MathNet.Numerics.LinearAlgebra.Complex
{
    using MathNet.Numerics.LinearAlgebra.Storage;
    using System;
    using System.Numerics;

    public class ModifiedSparseRowStorage : ModifiedSparseRowStorage<Complex>
    {
        /// <inheritdoc />
        public ModifiedSparseRowStorage(int rowCount, int columnCount)
            : base(rowCount, columnCount, 0)
        {
        }

        /// <inheritdoc />
        public ModifiedSparseRowStorage(int rowCount, int columnCount, int valueCount)
            : base(rowCount, columnCount, valueCount)
        {
        }

        /// <summary>
        /// Multiplies a matrix by a vector, y = alpha * A*x + beta * y;
        /// </summary>
        /// <param name="x">Vector of length m (column count).</param>
        /// <param name="y">Vector of length n (row count).</param>
        public void Multiply(Complex alpha, Complex[] x, Complex beta, Complex[] y)
        {
            var ax = this.Values;
            var ai = this.Indices;

            int n = this.rowCount;

            for (int i = 0; i < n; i++)
            {
                y[i] = beta * y[i] + alpha * ax[i] * x[i];
            }

            for (int i = 0; i < n; i++)
            {
                // Compute product of row i with vector x.
                for (int k = ai[i]; k < ai[i + 1] - 1; k++)
                {
                    y[i] += alpha * ax[k] * x[ai[k]];
                }
            }
        }
    }
}
