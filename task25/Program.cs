// 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
double result = 1;
Console.WriteLine("\nВведите любое число: ");
double A = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("\nВведите любое целое число: ");
int B = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= B; i++) result = result * A;
    Console.WriteLine($"\n{A} в степени {B} = {Math.Round(result, 3)} (округлено до 3-го знака после запятой)");