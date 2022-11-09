// Задача *: Напишите программу, которая из массива случайных чисел.
//  Ищет второй максимум (число меньше максимального элемента, но больше всех остальных).
//   Постарайтесь сделать одним циклом 
// [1, 3, 5, 6, 6, 4] -> 5

int[] CreatArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write(array[0]);
    for (int i = 1; i < array.Length; i++)
    {
        System.Console.Write($", {array[i]}");
    }
    System.Console.WriteLine("");
}

int FindSecMax(int[] array)
{
    int max = array[0];
    int secMax = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i]) 
        {
            secMax = max;
            max = array[i];
        }
        if (max > array[i] && secMax < array[i]) secMax = array[i];
    }
    return secMax;
}
System.Console.Write($"Массив из 8 элементов от 0 до 10 -> ");
int[] myArray = CreatArray(8);
PrintArray(myArray);
System.Console.WriteLine($"Второе по величине число в массиве = {FindSecMax(myArray)}");
