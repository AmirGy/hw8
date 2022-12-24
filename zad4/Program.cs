/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся (HARD - случайных уникальных) двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

void unique(int[,,] A)
{
    for (int x = 0; x < A.GetLength(0); x++)
        for (int y = 0; y < A.GetLength(1); y++)
        {
            for (int z = 0; z < A.GetLength(2); z++)
            {
                A[x, y, z] = new Random().Next(10, 100);
                Console.Write($"{A[x,y,z]}({x},{y},{z}) ");
            }
            Console.WriteLine();
        }
}

Console.Write("Введите x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z: ");
int z = Convert.ToInt32(Console.ReadLine());

int[,,] A = new int[x,y,z];
unique(A);


