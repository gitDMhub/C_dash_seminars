// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

int ResultNumbers(int n, int m)
{
if (n > m)
{ int t = n;
n = m;
m = t;
}
if (n == m)
return n;
return ResultNumbers(n, m - 1) + m;
}

Console.Clear();
Console.Write("Задайте значения N и M через пробел: ");
string[] num = Console.ReadLine().Split(' '); // ввод двух чисел в одну строку
int n = int.Parse(num[0]);
int m = int.Parse(num[1]);
Console.WriteLine($"Сумма натуральных элементов в промежутке от {n} до {m} равна: {ResultNumbers(n, m)}");
