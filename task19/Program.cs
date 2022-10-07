// Задача 19. Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
Console.Clear();
string x = "0";
Console.Write("Введите целое положительное пятизначное число: ");
while (x.Length != 5)
x = Console.ReadLine();
if (Convert.ToInt32(x[0]) == Convert.ToInt32(x[4]) && Convert.ToInt32(x[1]) == Convert.ToInt32(x[3]))
    Console.WriteLine("\nЭто число палиндром");
else
    Console.WriteLine("\nЭто число не палиндром");