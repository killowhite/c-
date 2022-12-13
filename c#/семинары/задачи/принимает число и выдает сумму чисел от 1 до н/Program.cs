// Принимает н выдает сумму от 1 до н

int sum(int num)
{
    int sum = 1;
while(num > 1){
    sum +=num;
    num--;
}
return sum;
}
Console.WriteLine("ввеите число");
int number = Convert.ToInt32(Console.ReadLine());

int result = sum(number);
Console.WriteLine($"сумма от 1 до н = {result}");