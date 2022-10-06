Console.WriteLine("Введите любое целое число: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите другое целое число: ");
int x2 = Convert.ToInt32(Console.ReadLine());
if (x1 > x2)
    Console.WriteLine("Первое число больше второго");
else
    if (x1 == x2)
        Console.WriteLine("Оба числа равны");
    else
        Console.WriteLine("Второе число больше первого");
