/*
Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int M = EnterNumbers("Введите число M: ");
int N = EnterNumbers("Введите число N: ");
Console.WriteLine("Сумма чисел от " + M + " до " + N + " = " + SummFromMtoN(M, N));

int EnterNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}


int SummFromMtoN(int start, int end)
{
    if (start == end) return end;
    int summ = start;
    start++;
    return summ + SummFromMtoN(start, end);
}

