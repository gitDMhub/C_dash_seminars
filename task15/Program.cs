// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
Console.Clear();
Console.Write("Введите порядковый номер для дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day < 1 || day > 7)
    Console.WriteLine("\nОшибка! № дня недели не может быть меньше 1 и больше 7");
else
    if (day == 6 || day == 7)
        Console.WriteLine("\nЭто выходной день");
    else
        Console.WriteLine("\nИди работать!");
