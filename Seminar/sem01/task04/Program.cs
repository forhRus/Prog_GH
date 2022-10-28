
System.Console.Write("Введите число > ");
int x = Convert.ToInt32(Console.ReadLine());


if (x < 0)
{
    int i = x;
    int j = x * -1;
    while (i < j)
    {
        System.Console.Write(i + ", " );
        i++;
    }
    System.Console.WriteLine(j);
}
else
{
    if(x > 0)
    {
    int i = x * -1;
    int j = x;
    while (i < j)
    {
        System.Console.Write(i + ", " );
        // System.Console.Write(", ");
        i++;
    }
    System.Console.WriteLine(j);
    }
    else
    {
    System.Console.WriteLine(x);
    }
}

