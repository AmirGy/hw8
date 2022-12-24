/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

void MatrixProduct(int[,] A, int[,] B)
{
    int[,] C = new int[A.GetLength(0), B.GetLength(1)];
    for (int i = 0; i < C.GetLength(0); i++)
    {
        for (int j = 0; j < C.GetLength(1); j++)
        {
            C[i, j] = A[i, 0] * B[0, j] + A[i, 1] * B[1, j];
            Console.Write($"{C[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] FillMatrix(int[,] A, int rowsA, int colsA)
{
    for (int i = 0; i < rowsA; i++)
        for (int j = 0; j < colsA; j++)
        {
            Console.Write($"Введите A({i},{j})");
            A[i,j] = Convert.ToInt32(Console.ReadLine());
        }
    return A;
}


Console.Write("Введите количество строк матрицы А: ");
int rowsA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы А: ");
int colsA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк матрицы B: ");
int rowsB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы В: ");
int colsB = Convert.ToInt32(Console.ReadLine());

int[,] A = new int[rowsA, colsA];
int[,] B = new int[rowsB, colsB];
FillMatrix(A, rowsA, colsA);
FillMatrix(B, rowsB, colsB);
MatrixProduct(A, B);
