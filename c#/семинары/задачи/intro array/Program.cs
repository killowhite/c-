int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int[] array = {1, 2, 3, 4, 5, 6, 7, 9, 8};
array[0] = 12;
Console.WriteLine(array[0]);

/*int max1 = Max( a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(d1,d2,e1);
int max = Max(max1, max2, max3);

Console.WriteLine(max);*/