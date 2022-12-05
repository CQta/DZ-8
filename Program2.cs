int[,] GetArray(int m, int n, int minValue, int maxValue) 
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return result;
}

void Get_info(int[,] array, int x, int y)
{
    if(array.GetLength(0) >= x && array.GetLength(1) >= y)
    {
        Console.Write(array[x,y]);
    }
    else
    {
        Console.Write("Введены превышающие размер массива данные");
    }
    
}
Console.Clear();
Console.Write("Введите кол-во строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов массива: ");
int cols = int.Parse(Console.ReadLine()!);
Console.Write("Введите строчку: ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Введите столбец: ");
int y = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(rows, cols, 0, 9);
Get_info(array, x, y);