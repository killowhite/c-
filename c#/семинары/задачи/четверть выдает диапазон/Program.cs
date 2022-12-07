// пользователь вводит четверть программа выдает диапозон возможных координат
void Diapozon(int quadrant)
{
    if(quadrant == 1)Console.WriteLine("x > 0, y > 0");
   else if(quadrant == 2)Console.WriteLine("x < 0, y > 0");
   else if(quadrant == 3)Console.WriteLine("x < 0, y < 0");
 else if(quadrant == 4)Console.WriteLine("x > 0, y < 0");
    else Console.WriteLine("Это не четверть");
}
Console.WriteLine("Введите четверть");
int quadrantPoint = Convert.ToInt32(Console.ReadLine());
Diapozon(quadrantPoint);