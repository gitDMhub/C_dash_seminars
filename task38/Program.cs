// 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Convert.ToDouble(new Random().Next(-100, 101));
}

double ReleaseArray(double[] array)
{
    double result = 0;
    double aMAX = array[0];
    double aMIN = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(aMAX < array[i])
            aMAX = array[i];
        if(aMIN > array[i]) 
            aMIN = array[i];
        result = aMAX - aMIN;
    }
    return result;
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"Начальнаый массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Pазницa между максимальным и минимальным элементaми массива равна: {ReleaseArray(array)}");
