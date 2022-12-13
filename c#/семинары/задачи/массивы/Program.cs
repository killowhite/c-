int[] CreateRandomArray(int size, int minValue, int maxValue){
    int[] array = new int[size];

    for(int i = 0; i < size; i++){
        array[i] = new Random().Next(minValue, maxValue +1);
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
Console.WriteLine(" введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" введите мин ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введте макс");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);