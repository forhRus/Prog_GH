﻿// Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// Не использовать строки для расчета.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(-1000, 1000); // присваиваем случайное трёхзнчное число.

int res(int num) // функция устранение второй цифры и компиляции двузначного числа из оставшихся двух.
{
    int num1 = num % 10;
    int num2 = num / 100;
    num = num2 * 10 + num1;
    return num;
}
Console.WriteLine($"число {number} без второй цифры выглядит так - {res(number)}."); // выводим ресультат.