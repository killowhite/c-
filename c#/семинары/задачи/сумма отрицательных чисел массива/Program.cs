// Cгенерировать массив из 12 элеиентов от -9 до 9 найдите сумму отрицательных чисел массива 

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

int GetSumOfNegatives(int[]array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
        {
            sum += array[i]; //sum = sum + array[i];
        }
    }
    return sum;
}

Console.WriteLine("Введите размер массива ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = GreateRandomArray(size, min, max);
ShowArray(myArray);
int result = GetSumOfNegatives(myArray);
Console.WriteLine("сумма отрицательных эллементов" + result);