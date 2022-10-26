System.Console.Write("Введите число > ");
string num = Console.ReadLine();
int a = Convert.ToInt32(num);

int f(int x)
{
    int cube = x * x * x;
    return cube;
}

System.Console.WriteLine(f(a));