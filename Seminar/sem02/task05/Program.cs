// 2.1. Напишите программу, которая выводит случайное число из отрезка [10, 9999] и показывает наибольшую цифру числа.
// 7812 -> 8 
// 1213-> 3 
// 845 -> 8

int num = new Random().Next(10, 1000);
Console.WriteLine(num);
int maxDigit = num % 10;
while(num > 0)
{
    int temp = num % 10;
    if(maxDigit < temp) maxDigit = temp;
    num = num / 10;
}
Console.WriteLine(maxDigit);