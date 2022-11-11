// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

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

void ResultMatrix(int[,] matrix, int[,] matrix1, int[,] matrix2)
{
for (int i = 0; i < matrix.GetLength(0); i++)
    {
    for (int j = 0; j < matrix.GetLength(1); j++)
        {
        matrix[i,j] = matrix1[i,j] * matrix2[i,j];
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
int[,] matrix1 = new int[n, m];
int[,] matrix2 = new int[n, m];
Console.WriteLine("\nInitial Matrix 1:");
InitialMatrix(matrix1);
Console.WriteLine("\nInitial Matrix 2:");
InitialMatrix(matrix2);
Console.WriteLine("\nResult Matrix:");
ResultMatrix(matrix, matrix1, matrix2);