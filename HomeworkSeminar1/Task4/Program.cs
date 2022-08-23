/*
Задача 4: Напишите программу, которая принимает 
на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
using System;

Console.Write("Введите первое число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int z = Convert.ToInt32(Console.ReadLine());
int max = x;

if(x > max) max = x;
if(y > max) max = y;
if(z > max) max = z;

Console.WriteLine("max = " + max);