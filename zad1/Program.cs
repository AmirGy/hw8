/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

int[,] CreateFillArray(int rows, int cols)
{
    int[,] array = new int[rows, cols];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 11);
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],2}\t ");
        Console.WriteLine();
    }
}

int[,] Sort(int[,] array)
{
    Console.WriteLine("Измененный массив: ");
    int temp = 0;
    for (int k = 0; k < array.GetLength(0); k++)
        for (int i = 0; i < array.GetLength(1); i++)
            for (int j = i + 1; j < array.GetLength(1); j++)
                if (array[k, i] < array[k, j])
                {
                    temp = array[k, i];
                    array[k, i] = array[k, j];
                    array[k, j] = temp;
                }
    return array;
}



Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] matrix = CreateFillArray(rows, cols);
PrintArray(matrix);
Sort(matrix);
PrintArray(matrix);

