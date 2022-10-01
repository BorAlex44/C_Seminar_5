using static System.Console;
Clear();
Write("Введите длину массива: ");
int size = int.Parse(ReadLine()!);
Write("Введите минимальное значение массива: ");
int min = int.Parse(ReadLine()!);
Write("Введите максимальное значение массива: ");
int max = int.Parse(ReadLine()!);
int[] Array = GetRandomArray(size, min, max);
WriteLine($"[{String.Join(",", Array)}]");
int summa = GetSummaNotEvenElement(Array);
WriteLine($"Сумма нечетных элементов массива - {summa}");










int[] GetRandomArray(int lenght, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] result = new int[lenght];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue);
    }
    return result;
}

int GetSummaNotEvenElement(int[] NewArray)
{
    int result = 0;
    for (int i = 1; i < NewArray.Length; i += 2)
    {
        result += NewArray[i];
    }
    return result;
}

