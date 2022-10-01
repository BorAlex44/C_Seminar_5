using static System.Console;
Clear();
Write("Введите длину массива: ");
int size = int.Parse(ReadLine()!);
Write("Введите минимальное значение массива: ");
int min = int.Parse(ReadLine()!);
Write("Введите максимальное значение массива: ");
int max = int.Parse(ReadLine()!);
double[] Array = GetRandomArray(size, min, max);
WriteLine($"[{String.Join(" ", Array)}]");
double difference = GetDifferenceMaxMin(Array);
WriteLine($"Разница между максимальным и минимальным значением массива {difference}");








double[] GetRandomArray(int lenght, int minValue, int maxValue)
{
    Random rnd = new Random();
    double[] result = new double[lenght];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = Math.Round(rnd.Next(minValue, maxValue + 1) + rnd.NextDouble(), 2);
    }
    return result;
}

double GetDifferenceMaxMin(double[] MyArray)
{
    double result = 0;
    double maxNumber = Array[0];
    double minNumber = Array[0];
    foreach (double elem in MyArray)
    {
        if (elem > maxNumber)
        {
            maxNumber = elem;
        }
        else
        {
            if (elem < minNumber)
            {
                minNumber = elem;
            }
        }

    }
    result = Math.Round((maxNumber - minNumber), 2);
    return result;
}