Console.Clear();
Console.WriteLine("Введите любое целое положительное число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вот все чётные числа от 1 до " + x + ":");
for (int i = 2; i <= x; i+=2)
    Console.Write(i + " ");