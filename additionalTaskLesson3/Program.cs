// Сбор черники. 
// https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=5&id_topic=113&id_problem=695
int N = 5; 
int[] blueberry = {5, 2, 3, 4, 5};
int max = 0;
int t = 0;
for (int i = 1; i < N-1; i++)
    {
    t = blueberry[i-1] + blueberry[i] + blueberry[i+1];
    if (t > max) max = t;
    }
t = blueberry[N-2] + blueberry[N-1] + blueberry[0];
if (t > max) max = t;
Console.WriteLine($"\nМаксимальное количество черники с трёх кустов = {max}");
