// Ввод н вывод 5 квадратных чисел до н
void Squares(int number)
{
    int counter = 1;
    while(counter <= number)
    {
        Console.Write($"{Math.Pow(counter, 2)}");
        if(counter != number) Console.Write(" , ");
        counter++;
    }
}
Console.Write("Напишите число");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ряд квадратных чисел");
Squares(num);