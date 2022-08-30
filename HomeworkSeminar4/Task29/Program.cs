/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

void FillArray(int[] numbers)
{
    Console.WriteLine("Введите массив: ");
    for(int index = 0; index < numbers.Length; index++)
        //numbers[index] = new Random().Next(1, 51);  вариант с рандомным массивом
        numbers[index] = Convert.ToInt32(Console.ReadLine());
}

void PrintArray1(int[] num)
{
    //Console.Write(" -> [");
    for(int position = 0; position < num.Length; position++)
        Console.Write(num[position] + ", ");
    
     
}

int[] array = new int[8];
FillArray(array);
PrintArray1(array);
Console.Write($" -> [PrintArray(array)]");
Console.WriteLine();

    

