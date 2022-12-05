int[] GetArray(int m) 
{
    int[] result = new int[m];

    for (int i = 0; i < m; i++)
    {
        result[i] = new Random().Next(-100,101);
    }
    return result;
}

void PrintArray(int[] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        Console.Write(inArray[i] + " ");
    }
    Console.WriteLine(" ");
}

void PrintOddSum(int[] inArray)
{
    int sum = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        if(i % 2 ==1)
        {
            sum+=inArray[i];
        }
    }
    Console.Write(sum);
}
Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int rows = int.Parse(Console.ReadLine()!);
int[] array = GetArray(rows);
PrintArray(array);
PrintOddSum(array);