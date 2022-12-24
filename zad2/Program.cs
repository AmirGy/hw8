/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

int[,] CreateFillArray(int rows, int cols)
{
    int[,] array = new int[rows, cols];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
            array[i, j] = new Random().Next(0, 10);
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],3}\t ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FindMinString(int[,] array)
{
    int[] SumString = new int[array.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            sum += array[i,j];
        SumString[i] = sum;
        sum = 0;
    }
    int min = SumString[0];
    for (int i = 0; i < SumString.Length; i++)
        for (int j = i+1; j < SumString.Length; j++)
            if(SumString[i] < SumString[j])
                min = i + 1;
    Console.Write($"Наименьшая сумма элементов в {min} строке.");
}

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] table = CreateFillArray(rows, cols);
PrintArray(table);
FindMinString(table);

