int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int a1 = 10;
int a2 = 11;
int b1 = 20;
int b2 = 21;
int c1 = 40;
int c2 = 41;
int d1 = 70;
int d2 = 61;
int e1 = 55;

int max1 = Max( a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(d1,d2,e1);
int max = Max(max1, max2, max3);

Console.WriteLine(max);