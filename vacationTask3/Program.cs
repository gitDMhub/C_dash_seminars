//task 3. Змейка.

void InputMatrix(int[,] matrix)
{
int number = 0;
// double temp = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    // temp = Convert.ToDouble(i);
    if (i%2 == 0)
        {
        for (int j = 0; j < matrix.GetLength(1); j++)
            {
            matrix[i, j] = number;
            number = number + 1;
            }
        }
    else
        for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
            {
            matrix[i, j] = number;
            number = number + 1;
            }
}
}

void PrintMatrix(int[,] matrix)
{
Console.WriteLine();
for (int i = 0; i < matrix.GetLength(0); i++)
    {
    for (int j = 0; j < matrix.GetLength(1); j++)
        {
        if (matrix[i,j] < 10)
            Console.Write($" {matrix[i, j]} ");
        else
            Console.Write($"{matrix[i, j]} ");
        }
    Console.WriteLine();
    }
}

Console.Clear();
int n = 11;
int m = 11;
while (n > 10 && m > 10)
    {
    Console.Write("Введите кол-во строк (максимум 10): ");
    n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите кол-во столбцов (максимум 10): ");
    m = Convert.ToInt32(Console.ReadLine());
    }
int[,] matrix = new int[n, m];
InputMatrix(matrix);
PrintMatrix(matrix);
