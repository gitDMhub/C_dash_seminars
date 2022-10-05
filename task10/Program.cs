Console.Clear();
Console.Write("Введите трёхзначное целое число: ");
int xyz = Convert.ToInt32(Console.ReadLine());
if ((xyz > 99 && xyz < 1000) || (xyz < -99 && xyz > -1000))
    {
    int y = xyz / 10 %10;
    if (y < 0)
            y = y * -1;
    Console.WriteLine("\nВторая цифра Вашего числа: " + y);
    }
else 
    Console.WriteLine("Ошибка! Вы ввели НЕтрёхзначное число!");