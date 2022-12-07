int FindQuardant(double x, double y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}
Console.WriteLine("input x");
double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("input y");
double yA = Convert.ToDouble(Console.ReadLine());

int quadNum = FindQuardant(xA, yA);

Console.WriteLine($"The point A({xA}, {yA}) is DateOnly the {quadNum}");