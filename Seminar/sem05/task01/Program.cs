//Задайте массив из 12 элементов, заполненный случайными числами 
// из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6]
// сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] CreateArray(int length, int min, int max)
{
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write(array[0]);
    for (int i = 1; i < array.Length; i++)
    {
        System.Console.Write(", " + array[i]);
    }
}
int Sum(int[] array, bool isPositive = true)
{
    int invertor = 1;
    if (!isPositive)
    {
        invertor *= -1;
    }
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] * invertor) > 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

int len = 12;
int min = -9;
int max = 9;
int[] array = CreateArray(len, min, max);
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine($"Сумма положительных чисел = {Sum(array)}");
System.Console.WriteLine($"Сумма отрицательных чисел = {Sum(array, false)}");
