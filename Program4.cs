int[,,] GetArray(int m, int n, int b) 
{
    int[,,] result = new int[m, n, b];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int z = 0; z < b; z++)
            {
                result[i, j, z] = new Random().Next(10, 100);
            }
        }
    }

    return result;
}

void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int z = 0; z < inArray.GetLength(2); z++)
            {
                Console.Write($"{inArray[i, j, z] + "(" + i + " " + j + " " + z + ")"}\t ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Clear();
Console.Write("Введите кол-во строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов массива: ");
int cols = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во глубины массива: ");
int dep = int.Parse(Console.ReadLine()!);
int[,,] array = GetArray(rows, cols, dep);
PrintArray(array);
