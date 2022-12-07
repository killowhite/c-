double Distance(double xA , double yA , double xB , double yB, double zA, double zB)
{
    double length = Math.Sqrt(Math.Pow(xB - xA , 2) + Math.Pow(yB - yA , 2) + Math.Pow(zB - zA , 2));
    return Math.Round(length,2);
}
Console.Write("Введите координаты Xa ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты Ya ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты zA ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты Yb ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Ввеите коорщинаты xB ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты zB ");
double zB = Convert.ToDouble(Console.ReadLine());

double DistanceBetweenAB = Distance(xA, yA, xB, yB, zA, zB);
Console.WriteLine($"Дистанция между А и В {DistanceBetweenAB}");
