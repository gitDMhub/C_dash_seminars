// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
void InitialMatrix(int[,] matrix)
{
int[] summ = new int[matrix.GetLength(0)];
for (int i = 0; i < matrix.GetLength(0); i++)
    {
    Console.Write($"Row {i+1}:\t");
    for (int j = 0; j < matrix.GetLength(1); j++)
        {
        matrix[i,j] = new Random().Next(0,10);
        Console.Write($"{matrix[i,j]} \t");
        summ[i] = summ[i] + matrix[i,j];
        }
    Console.WriteLine();
    }
int comp = summ[0], indx1 = 1, indx2 = 0;
for (int i = 1; i < summ.GetLength(0); i++)
    {
    if (summ[i] < comp)
        {
        comp = summ[i];
        indx1 = i+1;
        }
    else if(summ[i] == comp)
        indx2 = i+1;
    }
if (indx2 == 0)
    Console.WriteLine($"\nThe row with minimum sum of elements is {indx1}");
else
    Console.WriteLine($"\nRows with minimum sum of elements are {indx1} and {indx2}");
}

Console.Clear();
Console.Write("Enter the number of rows and columns of the matrix separated by a space: ");
string[] num = Console.ReadLine().Split(' ');
int n = int.Parse(num[0]);
int m = int.Parse(num[1]);
int[,] matrix = new int[n, m];
Console.WriteLine("\nThe Matrix:");
InitialMatrix(matrix);
