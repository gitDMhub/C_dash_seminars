// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();
Console.Write("Введите число: ");
Double n = Convert.ToDouble(Console.ReadLine());
if (n > 0)
    {Console.WriteLine($"Кубы чисел от 1 до {n}:\n");
    for (int i = 1; i <= Convert.ToInt32(n); i++)
        Console.Write($"{i * i * i}; ");
        if (n > Convert.ToInt32(n))
        Console.Write($"{n * n * n}");
    }