//task 2. Соревнования по метанию молота.

void InputMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
	{
	for (int j = 0; j < matrix.GetLength(1); j++)
		matrix[i, j] = new Random().Next(0, 10);
	}
}

void PrintMatrix(int[,] matrix)
{
Console.WriteLine();
for (int i = 0; i < matrix.GetLength(0); i++)
	{
    Console.Write($"Cпортсмен №{i+1} \t");
	for (int j = 0; j < matrix.GetLength(1); j++)
		Console.Write($"{matrix[i, j]} \t");
	Console.WriteLine();
	}
}

Console.Clear();
Console.Write("Введите кол-во спортсменов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во бросков: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
InputMatrix(matrix);
PrintMatrix(matrix);
int max = 0;
int count = 0;
int lin = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
	{
	for (int j = 0; j < matrix.GetLength(1); j++)
        {
    	if (matrix[i,j] > max) 
            {
            max = matrix[i,j];
            lin = i;
            count = 1;
            }
        }
    }
for (int i = 0; i < matrix.GetLength(0); i++)
	{
	for (int j = 0; j < matrix.GetLength(1); j++)
        {
        if (matrix[i,j] == max && lin != i)
            {
            count = count + 1;
            lin = i;
            }
        }
    }
Console.WriteLine($"\nМаксимальный результат = {max}\nKоличество победителей = {count}");
