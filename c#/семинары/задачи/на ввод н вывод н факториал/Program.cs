// принимает н выдает н факториал
int facktorial(int num){
    int f = 1;
    while(num>1){
        f *=num;
        num--;
    }
return f;
}
Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
int result = facktorial(number);
Console.WriteLine($"факториал числа = {result}");