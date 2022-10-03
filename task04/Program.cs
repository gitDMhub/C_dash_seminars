int max, x1, x2, x3;
Console.WriteLine("Введите любое целое число: ");
x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите другое целое число: ");
x2 = Convert.ToInt32(Console.ReadLine());
if (x1 > x2)
    max = x1;
else
    max = x2;
Console.WriteLine("Введите ещё одно целое число: ");
x3 = Convert.ToInt32(Console.ReadLine());
if (max < x3)
    max = x3;
Console.WriteLine("Максимальное число = " + max);