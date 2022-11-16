// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[] CreateArray(int num)
{
    if (num < 2)
    {
        num = 2;
    }
    int[] array = new int[num];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < num; i++)
    {
        array[i] = array[i - 2] + array[i - 1];
    }
    return array;
}
void PrintArray(int[] ar)
{
    System.Console.Write(ar[0]);
    for (int i = 1; i < ar.Length; i++)
    {
        System.Console.Write(", "+ ar[i]);
    }
    System.Console.WriteLine("");

}

int number = Prompt("Сколько чисел из последовательности Фибоначи показать? -> ");
int[] myAr = CreateArray(number);
PrintArray(myAr);


