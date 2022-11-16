// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.

(int a, int b, int c) Prompt(string message)
{
    System.Console.Write(message + "a -> ");
    int a = int.Parse(Console.ReadLine());
    System.Console.Write(message + "b -> ");
    int b = int.Parse(Console.ReadLine());
    System.Console.Write(message + "c -> ");
    int c = int.Parse(Console.ReadLine());
    return (a, b, c);
}

bool ValTri(int a, int b, int c)
{
    if (a > b + c || b > a + c || c > a + b) return false;
    return true;
}

(int a, int b, int c) = Prompt("Введите значение стороны ");
if (ValTri(a, b, c)) System.Console.WriteLine("Всё отлично, такой триугольник может существовать!");
else System.Console.WriteLine("Значение одной из сторон слишком большое.");
