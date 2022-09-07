/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/




void PointsRead(int B1, int K1, int B2, int K2)
{
    Console.Write("Введите значение b1: ");
    int b1 = Convert.ToInt32(Console.ReadLine());
    b1 = B1;
    Console.Write("Введите значение k1: ");
    int k1 = Convert.ToInt32(Console.ReadLine());
    k1 = K1;
    Console.Write("Введите значение b2: ");
    int b2 = Convert.ToInt32(Console.ReadLine());
    b2 = B2;
    Console.Write("Введите значение k2: ");
    int k2 = Convert.ToInt32(Console.ReadLine());
    k2 = K2;
}

PointsRead(B1, K1, B2, K2);