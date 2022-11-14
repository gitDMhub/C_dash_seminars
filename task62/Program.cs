// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] matrix = new int[4,4];
int Num = 1;
int Tr = 0;
int Tc = 0;
// 00 -> 03
for (int j = Tr; j < matrix.GetLength(1); j++)
    {
    matrix[Tr,j] = Num;
    Num++;
    Tc = j; //=3
    }
// 03 -> 33
for (int i = Tr+1; i < matrix.GetLength(0); i++)
    {
    matrix[i,Tc] = Num;
    Num++;
    }
// 30 <- 32
for (int j = Tc-1; j >= Tr; j--)
    {
    matrix[Tc,j] = Num;
    Num++;
    }
// 10 <- 20
for (int i = Tc-1; i > Tr; i--)
    {
    matrix[i,Tr] = Num;
    Num++;
    }
Tr++; //=1
// 11 -> 12
for (int j = Tr; j < Tc; j++)
    {
    matrix[Tr,j] = Num;
    Num++;
    }
Tc--; //2
// 21 <- 22
for (int j = Tc; j >= Tr; j--)
    {
    matrix[Tc,j] = Num;
    Num++;
    }
Console.Clear();
Console.WriteLine("4x4 Matrix Filled With Consecutive Numbers in a Spiral:\n");
for (int i = 0; i < matrix.GetLength(0); i++)
    {
    for (int j = 0; j < matrix.GetLength(1); j++)
        {
        if (matrix[i,j] < 10)
            {Console.Write($"0{matrix[i, j]} \t");}
        else
            {Console.Write($"{matrix[i, j]} \t");}
        }
    Console.WriteLine();
    }