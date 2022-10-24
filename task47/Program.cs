﻿//task 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void InputMatrix(double[,] matrix)
{
double number;
Random rnd = new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
number = rnd.NextDouble();
matrix[i, j] = number*100;
}
}
}

void PrintMatrix(double[,] matrix)
{
Console.WriteLine();
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
Console.Write($"{Math.Round(matrix[i, j],3)} \t");
Console.WriteLine();
}
}

Console.Clear();
Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[n, m];
InputMatrix(matrix);
PrintMatrix(matrix);
