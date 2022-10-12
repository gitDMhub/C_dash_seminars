// ЗАДАЧА №1138	Второй максимум
// https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=3&id_topic=35&id_problem=223
Console.Clear();
int[] tz = {6, 2, 4, 5, 1, 4, 6, 7, 6, 8, 7, 9, 10, 11, 0, 12};
int max = tz[0]; int smax = tz[0];
if (tz[1] > max) max = tz[1];
    else smax = tz[1];
for (int i = 2; i < tz.Length && tz[i] != 0; i++)
    {
    if (tz[i] > max) 
        {
        smax = max;
        max = tz[i];
        }
    else if (tz[i] > smax) smax = tz[i];
    }
Console.WriteLine("\n[" + string.Join(", ", tz) + "]\n\nДля последовательности чисел, от начала этого массива до 0, второй максимум = " + smax);