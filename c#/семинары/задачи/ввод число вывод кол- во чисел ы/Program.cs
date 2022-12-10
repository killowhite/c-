// Поьзователь вводит число, программа выводит кол-во цифр в числе
/*Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
string txt = Convert.ToString(num);
*/

int NumOfDigits(int num)
{
    int count = 0;
    if(num == 0) count = 1;
    while(num !=0)
    {
        count++;
        num /=10;
    } 
    return count;
}
Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());

int result = NumOfDigits(number);
Console.WriteLine($"Кол-во чисел в {number} {result}");