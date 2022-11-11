// Задача 1: Напишите программу замены элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

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

int len = 12;
int min = -9;
int max = 9;
int[] array = CreateArray(len, min, max);
PrintArray(array);
PrintArray(array, false);



