﻿/*
Задача 5: Напишите программу, которая на вход принимает одно число (N), 
а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2"
*/
using System;
Console.Write("Ведите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int x = N * -1;
while(x <= N)
{
    Console.Write(x);
    Console.Write(", ");
    x++;
}
Console.WriteLine("Something Like That");