// программа превращает отрицательные числа в положительные и наоборот
int[] GreateArray(int size, int minValue, int maxValue)
{
    int[] array= new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}
void ShowArray(int[]array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"array[{i+1}] is {array[i]}");
    }
}

int[] revers(int[]array)
{
    for(int i = 0; i < array.Length; i++)
    {
        
        array[i] *= -1;
        
    }
    return array;
}

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введитее минимальное значение");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = GreateArray(size, min, max);
ShowArray(myArray);
int[] result = revers(myArray);
ShowArray(result);