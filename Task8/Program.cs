/*
Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/
using System;

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int x = 0;

while(x < N - 1)
{
    x = x + 2;
    Console.Write(x);
    Console.Write(", ");
}
Console.WriteLine(" как-то так");