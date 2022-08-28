/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
string PalindromCheck(string atext)
{
    if(atext[0] == atext[4] && atext[1] == atext[3])
        return atext + "-> да";
    else
        return atext + "-> нет";
}

Console.Write("Введите пятизначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
string atext = Convert.ToString(a);
Console.WriteLine(PalindromCheck(atext));


