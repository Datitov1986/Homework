/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
 и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/
using System;

void DayOfWeek(int num)
{
if(num < 1 || num > 7)
    Console.WriteLine("Нет такого дня недели");
else if(num == 6 || num == 7)
    Console.WriteLine("Ура! Сегодня выходной!");
else 
     Console.WriteLine("Сегодня не выходной, иди трудись");
}

Console.Write("Введите число от 1 до 7: "); 
int num = Convert.ToInt32(Console.ReadLine());
DayOfWeek(num);
/*if(num == 6 || num == 7)
 {
    Console.WriteLine("Ура! Сегодня выходной!");
 }
else if(num < 1 || num > 7)
{
    Console.WriteLine("Нет такого дня недели");
}
else
{
    Console.WriteLine("Сегодня не выходной, иди трудись");
}
*/