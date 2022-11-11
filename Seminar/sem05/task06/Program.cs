// Создаать массив и посчитать среднее значение.

int[] CreateArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

void PrintArray(int[] array, bool exp = true)
{
    int invert = 1;
    if (!exp)
    {
        invert = -invert;
    }
    System.Console.Write(array[0] * invert);
    for (int i = 1; i < array.Length; i++)
    {
        System.Console.Write(", " + array[i] * invert);
    }
    System.Console.WriteLine("");
}

double Average(int[] array)
{
    double res = 0;
    for (int i = 0; i < array.Length; i++)
    {
        res += array[i];
    }
    return res /= array.Length;
}

int length = 4;
int min = 0;
int max = 10;
int[] array = CreateArray(length, min, max);
PrintArray(array);
System.Console.WriteLine(Average(array));



