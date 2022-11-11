// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите  
// программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

void InitialMatrix(int[,,] matrix)
{
int init = new Random().Next(10, 20);
for (int i = 0; i < matrix.GetLength(0); i++)
    {
    for (int j = 0; j < matrix.GetLength(1); j++)
        {
        for (int k = 0; k < matrix.GetLength(2); k++)
            {
            matrix[i,j,k] = init;
            Console.Write($"{matrix[i,j,k]} ({i},{j},{k})\t");
            init = matrix[i,j,k] + k + 1;
            }
        Console.WriteLine();
        }
    Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Enter the number of matrix elements along the X, Y, and Z axes separated by a space: ");
string[] num = Console.ReadLine().Split(' ');
int l = int.Parse(num[0]);
int m = int.Parse(num[0]);
int n = int.Parse(num[1]);
int[,,] matrix = new int[l, m, n];
Console.WriteLine("\nInitial Matrix:");
InitialMatrix(matrix);
