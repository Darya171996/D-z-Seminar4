﻿// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11
//82 -> 10
//9012 -> 12


Console.WriteLine("Веедите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (num > 0)
{
    int n = num % 10;
    num = num / 10;
    sum = sum + n;
}
Console.WriteLine(sum);