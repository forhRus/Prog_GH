// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] CreateArray(int length, int min, int max)
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max) * 1.0;
    }
    return array;
}

void PrintArray(double[] array)
{
    System.Console.Write(array[0]);
    for (int i = 1; i < array.Length; i++)
    {
        System.Console.Write(", " + array[i]);
    }
    System.Console.WriteLine("");
}

(double, double) MinMaxNumber(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
        if (min > array[i]) min = array[i];
    }
    return (min, max);
}

double Result(double min, double max)
{
    return max - min;
}

int length = 10;
int min = 0;
int max = 10;
double[] array = CreateArray(length, min, max);
PrintArray(array);
//System.Console.WriteLine($"Разница максимального и минимального числа в массиве равна {Result(MinMaxNumber(array))}");
// почему-то функция Result не хочет принимать значачения из функции MinMaxNumber(array), ругается;
(double minNum, double maxNum) = MinMaxNumber(array);
System.Console.WriteLine($"Разница максимального и минимального числа в массиве равна {Result(minNum, maxNum)}");

