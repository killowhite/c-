﻿//программа вводит трехзначное число и удаляет второе число

int CutNumber(int num)
{
    int ed = num % 10;
    int sot = num / 100;

    int result = sot * 10 + ed;
    return result;
}

int randNum = new Random().Next(100, 1000);
int newNum = CutNumber(randNum);

Console.WriteLine($"New version of a number {randNum} is {newNum}");
