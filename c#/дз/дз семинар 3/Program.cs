//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/* double Distance(double xA , double yA , double xB , double yB, double zA, double zB)
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
Console.WriteLine($"Дистанция между А и В {DistanceBetweenAB}"); */

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/* void Cub(int number)
{
int counter = 1;
while(counter <= number)
{
    Console.Write($"{Math.Pow(counter, 3)}");
    if(counter != number) Console.Write(" , ");
    counter++;
}
}
Console.Write("Напишите целое число ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("таблица кубов");
Cub(num); */

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());
string numTxt = Convert.ToString(num);

if(numTxt[0] == numTxt[4] && numTxt[1] == numTxt[3] ){
    Console.WriteLine("палиндром");
}
else{
    Console.WriteLine("не палиндром");
}