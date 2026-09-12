using System;

class Program
{
        static void Main()
    {
        Console.Write("ВВЕДИТЕ ДЛИНУ");
        double a = double.Parse(Console.ReadLine().Replace(',', '.'));

        Console.Write("ВВЕДИТЕ  Высоту");
        double b = double.Parse(Console.ReadLine().Replace(',', '.'));
        double area = a * b;
        double perimeter = 2 * (a + b);
        Console.WriteLine($"ploshad {area}");
        Console.WriteLine($"perimetr{perimeter}");
    }
}