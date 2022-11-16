//  Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.


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


int length = 10;
int min = 0;
int max = 100;
int[] array = CreateArray(length, min, max);
int[] arCopy = array;
PrintArray(array);
array[0] = 450;
PrintArray(array);
PrintArray(arCopy);


