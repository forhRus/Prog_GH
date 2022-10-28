// 2. Напишите программу, которая выводит случайное число 
// из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

int number = new Random().Next(10, 100);

int maxDigit(int num)
{
    int a = num / 10;
    int b = num % 10;
    if (a > b) return a;
    else return b;
}

System.Console.WriteLine($"Наибольшая цифра в числе {number} является {maxDigit(number)}.");
