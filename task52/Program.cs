//task 52. Задайте двумерный массив из целых чисел. 
//         Найдите среднее арифметическое элементов в каждом столбце.

void InputMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
	{
	for (int j = 0; j < matrix.GetLength(1); j++)
		matrix[i, j] = new Random().Next(-10, 11);
	}
}

void PrintMatrix(int[,] matrix)
{
Console.WriteLine();
for (int i = 0; i < matrix.GetLength(0); i++)
	{
	for (int j = 0; j < matrix.GetLength(1); j++)
		Console.Write($"{matrix[i, j]} \t");
	Console.WriteLine();
	}
}

Console.Clear();
Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
InputMatrix(matrix);
PrintMatrix(matrix);
double result = 0;
for (int j = 0; j < matrix.GetLength(1); j++)
	{
	for (int i = 0; i < matrix.GetLength(0); i++)
    	result = result + matrix[i,j];
    result = result / m;
    Console.WriteLine($"\nCреднее арифметическое элементов в столбце {j+1} = {result}");
    result = 0;
	}
