// 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();
int result = 0;
Console.WriteLine("\nВведите любое число: ");
string xyz = Console.ReadLine();
xyz = xyz.Replace(",","");
int q = Convert.ToInt32(xyz);
if (q < 0) q = q*-1;
for (int i = 0; i < xyz.Length; i++) 
    {
    result = result + q%10;
    q = q/10;
    }
Console.WriteLine($"Сумма цифр в этом числе = {result}");