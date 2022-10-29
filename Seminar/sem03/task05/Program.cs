// Задача 5*: Напишите программу, которая генерирует последовательность
//  случайных чисел из 10 элементов в диапазоне от 1 до 10, и
//   подсчитывает, сколько сгенерировалось чисел больше 5.
int[] GetArr(int len)
{
    int[] numbers = new int[len];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1, 11);
        System.Console.Write(numbers[i] + " ");
    }
    System.Console.WriteLine();
    return numbers;
}

int num = 9;
int[] numArr = GetArr(10);
int GetCount(int num)
{
    int counter = 0;
    foreach (int item in numArr)
    {
        if (item > num)
        {
            counter++;
        }
    }  
    return counter;
}


System.Console.WriteLine($"в массиве чисел больше {num} = {GetCount(num)} штук.");
