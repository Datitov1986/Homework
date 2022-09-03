/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

void FillArray(int[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = new Random().Next(-20, 50);
        Console.Write($"{num[i]}, ");
    }
}

int[] array = new int[10];
FillArray(array);