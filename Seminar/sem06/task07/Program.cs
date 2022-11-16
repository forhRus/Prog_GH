// вывод чисел от 1 до n

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}
void Print(int n)
{
    if (n == 0) return;
    Print(n - 1);
    System.Console.Write(n + " ");
}
// int n = Prompt("Задайте число -> ");
Print(Prompt("Задайте число -> "));
System.Console.WriteLine("");
