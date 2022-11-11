// Задача 54: Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.
void InitialMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
    {
    for (int j = 0; j < matrix.GetLength(1); j++)
        {
        matrix[i,j] = new Random().Next(-20,21);
        Console.Write($"{matrix[i,j]} \t");
        }
    Console.WriteLine();
    }
}

void ResultMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
    {
    for (int col = 0; col < matrix.GetLength(1)-1; col++)
        {
        for (int j = col + 1; j < matrix.GetLength(1); j++)
            {
            if (matrix[i,j] > matrix[i,col])
                {
                int t = matrix[i,col];
                matrix[i,col] = matrix[i,j];
                matrix[i,j] = t;
                }
            }
        }
    }
for (int i = 0; i < matrix.GetLength(0); i++)
    {
    for (int j = 0; j < matrix.GetLength(1); j++)
        {
        Console.Write($"{matrix[i, j]} \t");
        }
    Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Enter the number of rows and columns of the matrix separated by a space: ");
string[] num = Console.ReadLine().Split(' ');
int n = int.Parse(num[0]);
int m = int.Parse(num[1]);
int[,] matrix = new int[n, m];
Console.WriteLine("\nInitial Matrix:");
InitialMatrix(matrix);
Console.WriteLine("\nResult Matrix:");
ResultMatrix(matrix);