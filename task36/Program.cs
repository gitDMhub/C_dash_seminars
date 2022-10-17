// 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях
void InputArray(double[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(-100, 101);
}

double ReleaseArray(double[] array)
{
double result = 0;
for (int i = 1; i < array.Length; i=i+2)
    {
    result = result + array[i];
    }
return result;
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"Начальнаый массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях равна: {ReleaseArray(array)}");