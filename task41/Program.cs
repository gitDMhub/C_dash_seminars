// 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Clear();
int result = 0;
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите {n} чисeл: \n");
for (int i=0; i < n; i++)
    {
    double m = Convert.ToDouble(Console.ReadLine());
    if (m > 0) result++;
    }
Console.WriteLine($"Из общего количества {n}, {result} числa больше 0.");