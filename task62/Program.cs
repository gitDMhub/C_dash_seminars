// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

void InitialMatrix(int[,] matrix)
{
int ColHeight = matrix.GetLength(0);
int RowLength = matrix.GetLength(1);
int Num = 1;
int Tr = 0;
for (int pass = 1; pass <= matrix.GetLength(0); pass++)
    {
    if (pass%2 != 0)
        {
        for (int j = Tr; j < RowLength; j++)
            {
            matrix[Tr,j] = Num;
            Num++;
            }
        RowLength--; //=3, 2
        for (int i = Tr+1; i < ColHeight; i++)
            {
            matrix[i,RowLength] = Num;
            Num++;
            }
        Tr++; //=1, 2
        ColHeight--; //=3, 2
        }
    else
        {
        for (int j = RowLength-1; j >= pass-2; j--)
            {
            matrix[ColHeight,j] = Num;
            Num++;
            }
        for (int i = ColHeight; i >= pass-1; i--)
            {
            matrix[i,pass-2] = Num;
            Num++;
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
Console.Write("Enter length of matrix sides: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, n];
Console.WriteLine("\n2D Matrix Filled With Numbers in a Spiral:");
InitialMatrix(matrix);
