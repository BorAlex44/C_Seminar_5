using static System.Console;
Clear();
Write("Введите длину массива: ");
int size = int.Parse(ReadLine()!);
int[] Array = GetRandomArray(size);
WriteLine($"[{String.Join(",", Array)}]");
int count = GetEvenNumbers(Array);
WriteLine($"Количество четных чисел в массиве - {count}");













int[] GetRandomArray(int lenght)
{
    Random rnd = new Random();
    int[] result = new int[lenght];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(100, 1000);
    }
    return result;
}


int GetEvenNumbers(int[] NewArray)
{
    int result = 0;
    for (int i = 0; i < NewArray.Length; i++)
    {
        if (NewArray[i] % 2 == 0)
        {
            result++;
        }
    }
    return result;
}
