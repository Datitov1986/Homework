﻿/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
 что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/
using System;

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string numText = Convert.ToString(num);
if(numText.Length > 2)
{
    Console.WriteLine("Третья цифра: " + numText[2]);

}
else
{
    Console.WriteLine("третьей цифры нет");
}