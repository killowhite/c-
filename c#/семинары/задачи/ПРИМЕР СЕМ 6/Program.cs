//Разворот массива
int[] GreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
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

void ReversArray(int[]array)
{
    for(int i = 0, j = array.Length - 1; i < j; i++, j++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введитее минимальное значение");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = GreateRandomArray(size, min, max);
ShowArray(myArray);
ReversArray(myArray);
ShowArray(myArray);