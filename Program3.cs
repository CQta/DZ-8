int[,] GetArray(int m, int n) 
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(0, 9);
        }
    }

    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Find_average(int[,] inArray)
{
    double sum;
    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        sum = 0;
        for (int j = 0; j < inArray.GetLength(0); j++)
        {
            sum += inArray[j,i];
        }
        Console.Write(Math.Round(sum/inArray.GetLength(0),2) + " ");
    }
}
Console.Clear();
Console.Write("Введите кол-во строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов массива: ");
int cols = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(rows, cols);
PrintArray(array);
Find_average(array);