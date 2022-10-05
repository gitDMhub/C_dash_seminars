// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет. 
// (Можно воспользоваться нумерацией строк, но необязательно)
Console.Clear();
Console.Write("Введите любое целое число: ");
string xyz = Console.ReadLine();
double q = Convert.ToDouble(xyz);
if (q < 0)
    xyz = Convert.ToString(q*-1);
if (xyz.Length < 3)
    Console.WriteLine("Третьей цифры нет");
else 
    // неудачная попытка убрать из сравнения десятичную запятую!
    // string s = ",";
    // if (Equals (xyz[2], s))
    //    Console.WriteLine("\nТретья цифра Вашего числа: " + xyz[3]);
    // else
Console.WriteLine("\nТретья цифра Вашего числа: " + xyz[2]);
    
    