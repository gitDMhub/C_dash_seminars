// Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.

int ResultNumbers(int m, int n)
{
if (m == 0)
    return n+1;
else 
    {
    if (m > 0 && n == 0)
        {
        return ResultNumbers(m - 1, 1);
        }
    else
        { 
        return ResultNumbers(m - 1, ResultNumbers(m, n - 1));
        }
    }
}

Console.Clear();
Console.Write("Задайте неотрицательные значения M < 4 и N < 12 через пробел: ");
string[] num = Console.ReadLine().Split(' '); // ввод двух чисел в одну строку
int m = int.Parse(num[0]);
int n = int.Parse(num[1]);
Console.WriteLine($"Значение функции Аккермана для чисел {m} и {n} равно: {ResultNumbers(m, n)}");
