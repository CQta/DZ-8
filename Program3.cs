void Get_Dot(double k1, double k2, double b1, double b2)
{
    Console.WriteLine("X = " + (b2-b1)/(k1-k2));
    Console.WriteLine("Y = " + (k2*((b2-b1)/(k1-k2))+b2));    
}

Console.Clear();
Console.Write("Введите k1: ");
double k1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите k2: ");
double k2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите b1: ");
double b1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите b2: ");
double b2 = double.Parse(Console.ReadLine()!);
Get_Dot(k1, k2, b1, b2);