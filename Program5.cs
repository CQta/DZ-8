System.Console.WriteLine("Введите длинну и ширину массива");
int rows = int.Parse(Console.ReadLine()!);
int[,] array = new int[rows,rows];
int i = 0;
int j = 0;
for(int temp =1; temp <= rows*rows; temp++)
{
    array[i,j] = temp;
    if(i <= j + 1 && i + j < rows-1) j++;
    else if(i < j && i + j >= rows - 1) i++;
    else if(i >= j && i+ j > rows - 1) j--;
    else i--;
}
for (int x = 0; x < array.GetLength(0); x++)
{
    for (int y = 0; y < array.GetLength(1); y++)
    {
        System.Console.Write($"{array[x,y]}\t");
    }
    System.Console.WriteLine();
}
