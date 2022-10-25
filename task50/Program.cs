//task 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//         и возвращает значение этого элемента или же указание, что такого элемента нет.

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
Console.WriteLine("В двумерном массиве 5x5");
Console.Write("Выберите позицию элемента по-горизонтали: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("И по-вертикали: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[5, 5];
InputMatrix(matrix);
PrintMatrix(matrix);
if (n <= 0 || n > matrix.GetLength(0) || m <= 0 || m > matrix.GetLength(1))
    Console.WriteLine($"\nTакого элемента нет!\n");
else
    Console.WriteLine($"\nЗначение элемента на позиции {n}, {m} = {matrix[n-1,m-1]}\n");
