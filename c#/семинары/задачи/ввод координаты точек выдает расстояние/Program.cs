// Ввод координаты, вывод расстояние
double Distance(double xA , double yA , double xB , double yB)
{
    double length = Math.Sqrt(Math.Pow(xB - xA , 2) + Math.Pow(yB - yA , 2));
    return Math.Round(length,2);
}
Console.Write("Введите координаты Xa ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты Ya ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты Xb ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты Yb ");
double yB = Convert.ToDouble(Console.ReadLine());

double DistanceBetweenAB = Distance(xA, yA, xB, yB);
Console.WriteLine($"Дистанция между А и В {DistanceBetweenAB}");

