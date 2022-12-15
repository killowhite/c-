// Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.

/* int Exponentiation(int numA, int numB)
{
  int result = 1;
  for(int i=1; i <= numB; i++)
  {
    result = result * numA;
  }

    return result;
}

  Console.Write("Введите число A: ");
  int numA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число B: ");
  int numB = Convert.ToInt32(Console.ReadLine());

  int exponentiation = Exponentiation(numA, numB);
  Console.WriteLine(exponentiation); */

  // Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

 /* Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int num)
  {
    
    int counter = Convert.ToString(num).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      advance = num - num % 10;
      result = result + (num - advance);
      num = num / 10;
    }
   return result;
  }

int sumNumber = SumNumber(num);
Console.WriteLine("Сумма " + sumNumber);*/


// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] GreateArray(int minValue, int maxValue)
{
  int[] array = new int[8];
  for(int i = 0; i < 8; i++)
  {
    array[i] = new Random().Next(minValue, maxValue +1);
  }
  return array;
}

void ShowArray(int[]array)
{
  for(int i = 0; i < array.Length; i++)
  {
Console.WriteLine($"array[{i +1}] is {array[i]}");
  }
}


Console.WriteLine("Введитее минимальное значение");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = GreateArray(min, max);
ShowArray(myArray);
