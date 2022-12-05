double[] GetArray(int m) 
{
    double[] result = new double[m];

    for (int i = 0; i < m; i++)
    {
        result[i] = Math.Round(new Random().NextDouble(), 2);
    }
    return result;
}

void PrintArray(double[] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        Console.Write(inArray[i] + " ");
    }
    Console.WriteLine(" ");
}

void PrintDiffMinMax(double[] inArray)
{
    double min = 2;
    double max = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        if(inArray[i]>max)
        {
            max = inArray[i];
        }
        else
        {
            if(inArray[i]<min)
            {
                min = inArray[i];
            }
        }
    }
    Console.Write("Разница между max и min = " + Math.Round(max-min,2));
}
Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int rows = int.Parse(Console.ReadLine()!);
double[] array = GetArray(rows);
PrintArray(array);
PrintDiffMinMax(array);