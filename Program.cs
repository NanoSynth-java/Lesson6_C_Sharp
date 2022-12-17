int[] GetArray(int minValue, int maxValue, int count)
{
    int[] array = new int[count];
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

int[] resultArray = GetArray(0, 10, 6);
Console.WriteLine(String.Join("; ", resultArray));

//1. Запись массива справо налево

int[] ReverseArray(int[] array)
{
    int[] result = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        result[i] = array[array.Length - 1 - i];
    }
    return result;
}

Console.WriteLine(String.Join("; ",ReverseArray(resultArray)));