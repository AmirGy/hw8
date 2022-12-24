/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

int[,] SpiralArray(int[,] spiral, int x)
{
    int i = 0;
    int j = 0;
    for (int number = 1; number <= x * x; number++)
    {
        spiral[i, j] = number;
        if (i <= j + 1 && i + j < x - 1)
            j++;
        else if (i < j && i + j >= x - 1)
            i++;
        else if (i >= j && i + j > x - 1)
            j--;
        else i--;
    }
    return spiral;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j], 2}\t ");
        Console.WriteLine();
    }
}

Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());

int[,] spiral = new int[x, x];
SpiralArray(spiral, x);
PrintArray(spiral);
