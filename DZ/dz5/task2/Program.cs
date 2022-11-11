// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
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
    System.Console.WriteLine("");
}

int Sum(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i += 2)
    {
        result += array[i];
    }
    return result;
}

int length = 10;
int min = 0;
int max = 10;
int[] array = CreateArray(length, min, max);
PrintArray(array);
System.Console.WriteLine($"сумма элементов массива на нечётной позиции = {Sum(array)}");
