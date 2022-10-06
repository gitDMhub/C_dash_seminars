// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет. 
// (Можно воспользоваться нумерацией строк, но необязательно)
Console.Clear();
Console.Write("Введите любое число: ");
string xyz = Console.ReadLine();
double q = Convert.ToDouble(xyz);
if (q < 0)
    xyz = Convert.ToString(q*-1);
xyz = xyz.Replace(",","");
if (xyz.Length < 3)
   Console.WriteLine("Третьей цифры нет");
else 
   Console.WriteLine("\nТретья цифра Вашего числа: " + xyz[2]);
