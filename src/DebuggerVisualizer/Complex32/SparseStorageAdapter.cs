﻿
namespace MathNet.MatrixDebuggerVisualizer.Complex32
{
    using MathNet.Numerics;
    using MathNet.Numerics.LinearAlgebra.Complex32;
    using MathNet.Numerics.LinearAlgebra.Storage;
    using System;
    using System.Collections.Generic;
    using MathNet.Numerics.Data.Matlab;
    using MathNet.Numerics.Data.Text;
    using MathNet.MatrixDebuggerVisualizer.Services;

    public class SparseStorageAdapter : IStorageAdapter
    {
        SparseMatrix matrix;
        SparseCompressedRowMatrixStorage<Complex32> storage;

        SparseStorageInfoService<Complex32> service;

        public SparseStorageAdapter(SparseMatrix matrix)
        {
            this.matrix = matrix;
            this.storage = matrix.Storage as SparseCompressedRowMatrixStorage<Complex32>;
            this.service = new SparseStorageInfoService<Complex32>(matrix, new MathService());
        }

        public int RowCount { get { return this.storage.RowCount; } }

        public int ColumnCount { get { return this.storage.ColumnCount; } }

        public object GetMatrix()
        {
            return matrix;
        }

        public object GetStorage()
        {
            return storage;
        }

        public string GetDataTypeName()
        {
            return "Complex32";
        }

        public StorageInfo GetStorageInfo(int level)
        {
            service.Update(level);

            return service.StorageInfo;
        }

        public void Save(string file)
        {
            if (file.EndsWith(".mat"))
            {
                MatlabWriter.Write<Complex32>(file, matrix, "A");
            }

            if (file.EndsWith(".mtx"))
            {
                MatrixMarketWriter.WriteMatrix<Complex32>(file, matrix);
            }

            if (file.EndsWith(".csv"))
            {
                DelimitedWriter.Write<Complex32>(file, matrix, ";");
            }

            throw new NotImplementedException();
        }

        public Tuple<double, double> GetValue(int i, int j)
        {
            if (i >= 0 && j >= 0 && i < storage.RowCount && j < storage.ColumnCount)
            {
                var value = matrix.At(i, j);

                return new Tuple<double, double>(value.Real, value.Imaginary);
            }

            return new Tuple<double, double>(0.0, 0.0);
        }

        public IEnumerable<MatrixEntry> Enumerate()
        {
            var ap = storage.RowPointers;
            var ai = storage.ColumnIndices;
            var ax = storage.Values;

            int end, n = storage.RowCount;

            for (int i = 0; i < n; i++)
            {
                end = ap[i + 1];

                for (int j = ap[i]; j < end; j++)
                {
                    yield return new MatrixEntry(i, ai[j], ax[j].Real, ax[j].Imaginary);
                }
            }
        }

        public IEnumerable<MatrixEntry> EnumerateSubmatrix(int rowStart, int rowEnd, int colStart, int colEnd)
        {
            var ap = storage.RowPointers;
            var ai = storage.ColumnIndices;
            var ax = storage.Values;

            int col, end, n = Math.Min(rowEnd, storage.RowCount);

            for (int i = rowStart; i < n; i++)
            {
                end = ap[i + 1];

                for (int j = ap[i]; j < end; j++)
                {
                    col = ai[j];

                    // We could break on (col > colEnd) since columns are always sorted.

                    if (col >= colStart && col <= colEnd)
                    {
                        yield return new MatrixEntry(i, ai[j], ax[j].Real, ax[j].Imaginary);
                    }
                }
            }
        }

        public IEnumerable<MatrixEntry> EnumerateRow(int i)
        {
            int start = storage.RowPointers[i];
            int end = storage.RowPointers[i + 1];

            var ai = storage.ColumnIndices;
            var ax = storage.Values;

            Complex32 a;

            for (int j = start; j < end; j++)
            {
                a =  ax[j];

                yield return new MatrixEntry(i, ai[j], a.Real, a.Imaginary);
            }
        }
    }
}
