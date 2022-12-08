int[,] GetArray(int m, int n) 
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(1, 100);
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

void Find_min(int[,] inArray)
{
    int sum = 0;
    int min_sum = 0;
    int ind_min_sum = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
                sum += inArray[i,j];
        }
        if(i==0 || sum<min_sum)
        {
            min_sum=sum;
            ind_min_sum = i;
        }
        sum=0;
    }
    Console.WriteLine(ind_min_sum+1 + " строка имеет минимальную сумму элементов");
}
Console.Clear();
Console.Write("Введите кол-во строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов массива: ");
int cols = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(rows, cols);
PrintArray(array);
Find_min(array);