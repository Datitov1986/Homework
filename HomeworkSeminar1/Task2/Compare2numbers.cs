/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
using System;

Console.Write("Введите первое число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int y = Convert.ToInt32(Console.ReadLine());

if(x > y)
{
    Console.Write("Первое число больше ");
}
else if(x==y)
{
    Console.Write("Да числа-то одинаковые! ");
}
else

    Console.Write("Второе число больше ");
