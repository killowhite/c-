﻿int[] array = {1, 12, 4, 9, 15, 6, 8, 16};

int n = array.Length;
int find = 4;

int index = 0;

while (index<n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break; //сохранить
    }
    index++;
}