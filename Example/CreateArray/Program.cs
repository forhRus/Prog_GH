int[] CreateArray(int length, int min, int max)
{
    int[] tempArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        tempArray[i] = new Random().Next(min, max);
    }
    return tempArray;
}

int[,] CreateMatrix(int i, int j)
{
    int[,] tempMatrix = new int[i, j];
    for (int i = 0; i < i; i++)
    {
        for (int j = 0; j < j; j++)
        {
            tempMatrix[i, j] = new Random().Next(0, 10);
        }
    }
    return tempMatrix;
}

double[,] CreateMatrix(int i, int j)
{
    double[,] tempMatrix = new double[i, j];
    for (int i = 0; i < i; i++)
    {
        for (int j = 0; j < j; j++)
        {
            tempMatrix[i, j] = new Random().Next(0, 10) + new Random().NextDouble();
        }
    }
    return tempMatrix;
}
