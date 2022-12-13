// принимает н выдает н факториал
 int facktorial(int num){
    int f = 1;
    /*while(num>1){
        f *=num;
        num--;
    }*/
    for(int i =2; i<= num; i++)
    {
        f*=i;
    }
return f;
}
Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
int result = facktorial(number);
Console.WriteLine($"факториал числа = {result}");