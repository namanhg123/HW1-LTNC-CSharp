using System;
using System.Collections.Generic;

class MatrixOperations
{
    // Ham nhap ma tran
    static int[,] InputMatrix(int rows, int cols)
    {
        int[,] matrix = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.WriteLine($"Nhap phan tu ({i + 1},{j + 1}): ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        return matrix;
    }

    // Ham hien thi ma tran
    static void DisplayMatrix(int[,] matrix, int rows, int cols)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    // Ham cong hai ma tran
    static int[,] AddMatrices(int[,] A, int[,] B, int rows, int cols)
    {
        int[,] result = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = A[i, j] + B[i, j];
            }
        }
        return result;
    }

    // Ham kiem tra kha nang nhan ma tran
    static bool CanMultiplyMatrices(int[,] A, int[,] B, int rowsA, int colsA)
    {
        return colsA == rowsA;
    }

    // Ham nhan hai ma tran
    static int[,] MultiplyMatrices(int[,] A, int[,] B, int rowsA, int colsA)
    {
        int[,] result = new int[rowsA, colsA];
        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < colsA; j++)
            {
                for (int k = 0; k < colsA; k++)
                {
                    result[i, j] += A[i, k] * B[k, j];
                }
            }
        }
        return result;
    }

    // Ham chuyen vi ma tran
    static int[,] TransposeMatrix(int[,] A, int rows, int cols)
    {
        int[,] transpose = new int[cols, rows];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                transpose[j, i] = A[i, j];
            }
        }
        return transpose;
    }

    // Ham tim gia tri lon nhat va nho nhat trong ma tran
    static void FindMinMax(int[,] A, int rows, int cols)
    {
        int min = A[0, 0], max = A[0, 0];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (A[i, j] < min) min = A[i, j];
                if (A[i, j] > max) max = A[i, j];
            }
        }
        Console.WriteLine($"\nGia tri nho nhat: {min}");
        Console.WriteLine($"Gia tri lon nhat: {max}");
    }

    // Ham kiem tra ma tran doi xung
    static bool IsSymmetric(int[,] A, int rows, int cols)
    {
        if (rows != cols)
        {
            return false;
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = i + 1; j < cols; j++)
            {
                if (A[i, j] != A[j, i])
                {
                    return false;
                }
            }
        }
        return true;
    }

    // Ham tinh dinh thuc ma tran vuong
    static int Determinant(int[,] matrix, int n)
    {
        if (n == 1)
            return matrix[0, 0];
        if (n == 2)
            return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];

        int det = 0;
        for (int p = 0; p < n; p++)
        {
            int[,] subMatrix = new int[n - 1, n - 1];
            for (int i = 1; i < n; i++)
            {
                int colIndex = 0;
                for (int j = 0; j < n; j++)
                {
                    if (j == p) continue;
                    subMatrix[i - 1, colIndex] = matrix[i, j];
                    colIndex++;
                }
            }
            det += matrix[0, p] * Determinant(subMatrix, n - 1) * ((p % 2 == 0) ? 1 : -1);
        }
        return det;
    }

    static void Main()
    {
        // Ask user for number of matrices and their dimensions
        Console.Write("Nhap so luong ma tran: ");
        int SoMaTran = int.Parse(Console.ReadLine());
        Console.Write("Nhap so dong cua ma tran: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Nhap so cot cua ma tran: ");
        int cols = int.Parse(Console.ReadLine());

        // Create and input matrices
        List<int[,]> matrices = new List<int[,]>();
        for (int i = 0; i < SoMaTran; i++)
        {
            Console.WriteLine($"\nNhap ma tran thu {i + 1}:");
            matrices.Add(InputMatrix(rows, cols));
        }

        // Display all matrices
        for (int i = 0; i < SoMaTran; i++)
        {
            Console.WriteLine($"\nMa tran thu {i + 1}:");
            DisplayMatrix(matrices[i], rows, cols);
        }

        // Example: Add first two matrices (if at least 2)
        if (SoMaTran >= 2)
        {
            Console.WriteLine("\nCong ma tran 1 + ma tran 2:");
            int[,] sum = AddMatrices(matrices[0], matrices[1], rows, cols);
            DisplayMatrix(sum, rows, cols);
        }

        // Example: Multiply first two matrices (if at least 2 and multiplication possible)
        if (SoMaTran >= 2 && cols == rows)
        {
            Console.WriteLine("\nNhan ma tran 1 * ma tran 2:");
            int[,] product = MultiplyMatrices(matrices[0], matrices[1], rows, cols);
            DisplayMatrix(product, rows, cols);
        }
        else if (SoMaTran >= 2)
        {
            Console.WriteLine("\nKhong the nhan ma tran 1 va 2 (so cot cua ma tran 1 phai bang so dong cua ma tran 2).");
        }

        // Transpose all matrices
        for (int i = 0; i < SoMaTran; i++)
        {
            Console.WriteLine($"\nChuyen vi cua ma tran thu {i + 1}:");
            int[,] transpose = TransposeMatrix(matrices[i], rows, cols);
            DisplayMatrix(transpose, cols, rows);
        }
    }
}







